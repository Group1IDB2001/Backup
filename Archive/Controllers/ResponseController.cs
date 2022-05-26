﻿using ArchiveLogic.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Archive.Controllers
{
    public class ResponseController : Controller
    {
        private readonly IResponseManager _manager;

        public ResponseController(IResponseManager manager)
        {
            _manager = manager;
        }

        [HttpPut]
        [Route("responses")]
        public async Task AddResponse([FromBody] CreateResponseRequest request) => await _manager.AddResponse(request.UserId, request.QestionId, request.Text, request.ItemId, request.CollectionId);
        







        [HttpGet]
        [Route("responses")]
        public async Task<IList<Response>> GetAllResponse() => await _manager.GetAllResponse();


        [HttpGet]
        [Route("responses/userid/{userid}")]
        public async Task<IList<Response>> GetResponseByUser(int userid) => await _manager.GetResponseByUser(userid);


        [HttpGet]
        [Route("responses/qestionid/{qestionid}")]
        public async Task<IList<Response>> GetResponseByQestion(int qestionid) => await _manager.GetResponseByQestion(qestionid);









        [HttpDelete]
        [Route("responses/{responseId}")]
        public async Task DeleteResponse(int responseId) => await _manager.DeleteResponse(responseId);












        [HttpPut]
        [Route("responses/edit/{responseId}")]
        public async Task EditResponse(int responseId, [FromBody] CreateResponseRequest request) =>await _manager.EditResponse(responseId, request.Text, request.ItemId, request.CollectionId);

        [HttpPut]
        [Route("responses/text/{responseId}")]
        public async Task EditResponseText(int responseId, [FromBody] CreateResponseRequest request) => await _manager.EditResponseText(responseId, request.Text);

        [HttpPut]
        [Route("responses/item/{responseId}")]
        public async Task EditResponseItem(int responseId, [FromBody] CreateResponseRequest request) => await _manager.EditResponseItem(responseId, request.ItemId);

        [HttpPut]
        [Route("responses/collection/{responseId}")]
        public async Task EditResponseCollection(int responseId, [FromBody] CreateResponseRequest request) => await _manager.EditResponseCollection(responseId, request.CollectionId);





        public IActionResult Index()
        {
            return View();
        }
    }
}
