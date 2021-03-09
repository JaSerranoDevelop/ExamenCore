using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BPT.Test.JASM.FrontEnd.Client
{
    public class ApiConnection
    {
        private const string WEBAPIURL = "https://localhost:44334";
        private const string WEBAPI_STUDENT = "/api/student";
        private const string WEBAPI_ASSIGMENT = "/api/Assigment";
        private const string WEBAPI_STUNDENT_ASSIGMENT = "/api/StudentAssigment";


        protected HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        private async Task<string> Get(string url)
        {

            var client = CreateHttpClient();
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }

        private bool PostObject<T>(T objeto, string url)
        {
            try
            {
                var serializedObject = JsonConvert.SerializeObject(objeto);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");

                var client = CreateHttpClient();
                var callResult = client.PostAsync(url, content).GetAwaiter().GetResult();

                return callResult.IsSuccessStatusCode && callResult.StatusCode == System.Net.HttpStatusCode.Created
                    || callResult.StatusCode == System.Net.HttpStatusCode.NoContent || callResult.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool Put<T>(T objeto, string url)
        {
            try
            {
                var serializedObject = JsonConvert.SerializeObject(objeto);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");

                var client = CreateHttpClient();

                var callResult = client.PutAsync(url, content).GetAwaiter().GetResult();


                return callResult.IsSuccessStatusCode && callResult.StatusCode == System.Net.HttpStatusCode.Created
                    || callResult.StatusCode == System.Net.HttpStatusCode.NoContent || callResult.StatusCode == System.Net.HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected T Get<T>(string url)
        {
            T result = default(T);
            try
            {
                var response = Get(url).GetAwaiter().GetResult();
                if (!string.IsNullOrWhiteSpace(response))
                    result = JsonConvert.DeserializeObject<T>(response);

                return result;
            }
            catch (Exception e)
            {
            }
            return result;
        }

        protected bool Delete(string url)
        {
            try
            {
                var client = CreateHttpClient();
                var callResult = client.DeleteAsync(url).GetAwaiter().GetResult();

                return callResult.IsSuccessStatusCode && callResult.StatusCode == System.Net.HttpStatusCode.Created
                  || callResult.StatusCode == System.Net.HttpStatusCode.NoContent || callResult.StatusCode == System.Net.HttpStatusCode.OK;

            }
            catch (Exception e)
            {
                throw;
            }
        }


        #region Student


        internal List<StudentDTO> GetListOfStudents()
        {
            try
            {
                var url = WEBAPIURL + WEBAPI_STUDENT;
                var result = Get<List<StudentDTO>>(url);

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        internal StudentListAssigmentsDTO GetStudent(Guid idStudent)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_STUDENT + "/" + idStudent.ToString();
                var result = Get<StudentListAssigmentsDTO>(url);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        internal StudentDTO PostStudent(StudentDTO studentDTO)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_STUDENT;
                var result = PostObject(studentDTO, url);

                if (result)
                    return studentDTO;

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal StudentDTO PutStudent(StudentDTO studentDTO)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_STUDENT + "/" + studentDTO.Id;
                var result = Put(studentDTO, url);

                if (result)
                    return studentDTO;

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        internal bool DeleteStudent (Guid id)
        {
            var url = WEBAPIURL + WEBAPI_STUDENT + "/" + id;
             return Delete(url);


        }

        #endregion

        #region Assigments


        internal List<AssigmentDTO> GetListOfAssigments()
        {
            try
            {
                var url = WEBAPIURL + WEBAPI_ASSIGMENT;
                var result = Get<List<AssigmentDTO>>(url);

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        internal AssigmentListStudentsDTO GetAssigment(Guid IdAssigment)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_ASSIGMENT + "/" + IdAssigment.ToString();
                var result = Get<AssigmentListStudentsDTO>(url);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        internal AssigmentDTO PostAssigment(AssigmentDTO assigmentDTO)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_ASSIGMENT;
                var result = PostObject(assigmentDTO, url);

                if (result)
                    return assigmentDTO;

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal AssigmentDTO PutAssigment(AssigmentDTO assigmentDTO)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_ASSIGMENT + "/" + assigmentDTO.Id;
                var result = Put(assigmentDTO, url);

                if (result)
                    return assigmentDTO;

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        internal bool DeleteAssigment(Guid id)
        {
            var url = WEBAPIURL + WEBAPI_ASSIGMENT + "/" + id;
            return Delete(url);


        }

        #endregion


        #region StudentAssiment


        internal StudentAssigmentDTO PostStudentAssigment(StudentAssigmentDTO studentAssigmentDTO)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_STUNDENT_ASSIGMENT;
                var result = PostObject(studentAssigmentDTO, url);

                if (result)
                    return studentAssigmentDTO;

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal StudenAssigmenDetailDTO GetStudentAssigment(string IdAssigment, string idstudent)
        {

            try
            {
                var url = WEBAPIURL + WEBAPI_STUNDENT_ASSIGMENT + "/" + idstudent + "/" + IdAssigment;
                var result = Get<StudenAssigmenDetailDTO>(url);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        internal bool DeleteStudentAssigment(string IdAssigment, string idstudent)
        {
            var url = WEBAPIURL + WEBAPI_STUNDENT_ASSIGMENT + "/" + idstudent + "/" + IdAssigment;
            return Delete(url);


        }

        #endregion
    }
}
