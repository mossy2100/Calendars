using Galaxon.Calendars.SpaceCalendars.com.Models;

namespace Galaxon.Calendars.SpaceCalendars.com.Repositories;

public interface IDocumentRepository : IRepository<Document>
{
    public IEnumerable<Document> GetPublished(bool published = true);
    public IEnumerable<Document> GetByFolder(int? folderId);
    public IEnumerable<Document> GetPublishedByFolder(int? folderId, bool published = true);
    public IEnumerable<Document> GetFolders();
    public int Reorder(int? folderId = null, int order = 0);
}
