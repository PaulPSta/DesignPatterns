namespace ProxyPattern
{
    public class AccessRights : IAccessRights
    {
        public bool DoesAUserHaveRightsToRetrieveResources()
        {
            return true;
        }
    }
}
