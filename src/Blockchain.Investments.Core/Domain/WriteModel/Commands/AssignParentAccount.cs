using System;

namespace Blockchain.Investments.Core.WriteModel.Commands
{
    public class AssignParentAccount : BaseCommand 
	{
        public readonly string UserId;
        public readonly string ParentAccountId;
        public AssignParentAccount(Guid id, string userId, string parentAccountId)
        {
            Id = id;
            UserId = userId;
            ParentAccountId = parentAccountId;
        }
	}
}