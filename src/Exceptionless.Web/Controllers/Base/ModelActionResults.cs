namespace Exceptionless.Web.Controllers;

public class ModelActionResults : WorkInProgressResult {
    public ModelActionResults() {
        Success = new List<string>();
        Failure = new List<PermissionResult>();
    }

    public List<string> Success { get; set; }
    public List<PermissionResult> Failure { get; set; }

    public void AddNotFound(IEnumerable<string> ids) {
        Failure.AddRange(ids.Select(PermissionResult.DenyWithNotFound));
    }
}
