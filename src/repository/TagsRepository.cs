using Taskd_manage_tags.src.dataservice;
using Taskd_manage_tags.src.models;

namespace Taskd_manage_tags.src.repository
{
    public class TagsRepository : ITagsRepository
    {
        ITagsDataservice _tagsDataservice;

        public TagsRepository(ITagsDataservice tagsDataservice)
        {
            _tagsDataservice = tagsDataservice;
        }

        public async Task<TagList> GetTagsByBoardId(int userId, int boardId)
        {
            try
            {
                TagList tagList = await _tagsDataservice.GetTagsByBoardId(userId, boardId);
                return tagList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        
        public async Task<TaskTagList> GetTaskTagsByUserIdAndBoardId(int userId, int boardId)
        {
            try
            {
                TaskTagList taskTagList = await _tagsDataservice.GetTaskTagsByUserIdAndBoardId(userId, boardId);
                return taskTagList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<int> CreateTag(string tagName, int userId, int boardId)
        {
            try
            {
                return await _tagsDataservice.CreateTag(tagName, userId, boardId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        
        public async Task<int> AddTagToTask(int userId, int boardId, int tagId, int taskId)
        {
            try
            {
                return await _tagsDataservice.AddTagToTask(userId, boardId, tagId, taskId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public void DeleteTag(int tagId, int userId)
        {
            try
            {
                _tagsDataservice.DeleteTag(tagId, userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}