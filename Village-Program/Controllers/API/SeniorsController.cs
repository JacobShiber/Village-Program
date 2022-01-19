using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Village_Program.Models;

namespace Village_Program.Controllers.API
{
    
    public class SeniorsController : ApiController
    {
        EldersContextDataContext dataContext = new EldersContextDataContext();
        // GET: api/Seniors
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(new { Massage = "Success", Seniors = dataContext.Seniors.ToList() });
            }
            catch(SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Seniors/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Senior expectedSenior = dataContext.Seniors.First(senior => senior.Id == id);

                return Ok(new { Massage = "Success", expectedSenior });
            }
            catch (SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Seniors
        public IHttpActionResult Post([FromBody]Senior newSenior)
        {
            try
            {
                dataContext.Seniors.InsertOnSubmit(newSenior);
                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, new senior added" });
            }
            catch (SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Seniors/5
        public IHttpActionResult Put(int id, [FromBody]Senior editedSenior)
        {
            try
            {
                Senior expectedSenior = dataContext.Seniors.First(senior => senior.Id == id);

                expectedSenior.Name = editedSenior.Name;
                expectedSenior.BirthDate = editedSenior.BirthDate;
                expectedSenior.Seniority = editedSenior.Seniority;

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, senior edited" });
            }
            catch (SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Seniors/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                dataContext.Seniors.DeleteOnSubmit(dataContext.Seniors.First(senior => senior.Id == id));

                dataContext.SubmitChanges();

                return Ok(new { Massage = "Success, senior deleted" });
            }
            catch (SqlException sqlEx)
            {
                return BadRequest(sqlEx.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
