using manage_tags.src.models;

namespace manage_tags.src.dataservice
{
    public interface ITagsDataservice
    {
        Task<TagList> GetTags(int userId, int boardId);

        Task<int> CreateTag(string tagName, int userId, int boardId);
        
        void DeleteTag(int tagId, int userId);
    }
}