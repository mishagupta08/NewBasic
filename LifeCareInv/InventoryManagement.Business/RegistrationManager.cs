using InventoryManagement.Business.Contract;
using InventoryManagement.DataAccess;
using InventoryManagement.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Business
{
    public class RegistrationManager:IRegistrationManager
    {
        RegistrationRepository objRegistrationRepo = new RegistrationRepository();

        public string GetPartyCode(string SelectedParentPartyCode, string SelectedGroupId)
        {
            return (objRegistrationRepo.GetPartyCode(SelectedParentPartyCode, SelectedGroupId));
        }
        public List<PartyModel> GetParentParty(decimal GroupId)
        {
            return (objRegistrationRepo.GetParentParty(GroupId));
        }
        public List<CityModel> GetCityList()
        {
            return (objRegistrationRepo.GetCityList());
        }
        public PartyModel GetParyOnPartyCode(string PartyCode, bool IsSupplier)
        {
            return (objRegistrationRepo.GetParyOnPartyCode(PartyCode, IsSupplier));
        }
        public List<StateModel> GetStateList()
        {
            return (objRegistrationRepo.GetStateList());
        }
        public ResponseDetail SavePartyDetails(PartyModel objPartyModel)
        {
            return (objRegistrationRepo.SavePartyDetails(objPartyModel));
        }
        public ResponseDetail DeleteApprovePartyDetails(PartyModel objPartyModel)
        {
            return (objRegistrationRepo.DeleteApprovePartyDetails(objPartyModel));
        }
        

        public ResponseDetail SavePartyApproveDetails(PartyModel objPartyModel)
        {
            return (objRegistrationRepo.SavePartyApproveDetails(objPartyModel));
        }

        
        public PartyModel GetApproveParyOnPartyCode(string PartyCode, bool IsSupplier , string Approveid)
        {
            return (objRegistrationRepo.GetApproveParyOnPartyCode(PartyCode,IsSupplier,  Approveid));
        }
        public List<PartyModel> GetAllPartyList(bool IsSupplier)
        {
            return (objRegistrationRepo.GetAllPartyList(IsSupplier));
        }


        public List<ApprovefranchiseList> GetAllAppoveFranchiseList(bool IsSupplier)
        {
            return (objRegistrationRepo.GetAllAppoveFranchiseList(IsSupplier));
        }

        public ResponseDetail IsDuplicatePartyUserName(string IsActionType, string PartyCode, string UserName)
        {
            return (objRegistrationRepo.IsDuplicatePartyUserName(IsActionType, PartyCode, UserName));
        }
        public PartyModel IsDuplicatePartyUserPartyCode(string IsActionType, string PartyCode, string UserName)
        {
            return (objRegistrationRepo.IsDuplicatePartyUserPartyCode(IsActionType, PartyCode, UserName));
        }
        public List<GroupModel> GetGroupList()
        {
            return (objRegistrationRepo.GetGroupList());
        }
    }
}