using InventoryManagement.API.Controllers;
using InventoryManagement.DataAccess.Contract;
using InventoryManagement.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.DataAccess
{
    public class RegistrationRepository:IRegistrationRepository
    {
        RegistrationAPIController objRegistrationAPI = new RegistrationAPIController();

        public string GetPartyCode(string SelectedParentPartyCode, string SelectedGroupId)
        {
            return (objRegistrationAPI.GetPartyCode(SelectedParentPartyCode, SelectedGroupId));
        }
        public List<PartyModel> GetParentParty(decimal GroupId)
        {
            return (objRegistrationAPI.GetParentParty(GroupId));
        }
        public List<CityModel> GetCityList()
        {
            return (objRegistrationAPI.GetCityList());
        }
        public List<StateModel> GetStateList()
        {
            return (objRegistrationAPI.GetStateList());
        }
        public ResponseDetail SavePartyDetails(PartyModel objPartyModel)
        {
            return (objRegistrationAPI.SavePartyDetails(objPartyModel));
        }
        public ResponseDetail DeleteApprovePartyDetails(PartyModel objPartyModel)
        {
            return (objRegistrationAPI.DeleteApprovePartyDetails(objPartyModel));
        }
        
        public ResponseDetail SavePartyApproveDetails(PartyModel objPartyModel)
        {
            return (objRegistrationAPI.SavePartyApproveDetails(objPartyModel));
        }


        
        public PartyModel GetParyOnPartyCode(string PartyCode, bool IsSupplier)
        {
            return (objRegistrationAPI.GetParyOnPartyCode(PartyCode,IsSupplier));
        }


        public PartyModel GetApproveParyOnPartyCode(string PartyCode, bool IsSupplier, string Approveid)
        {
            return (objRegistrationAPI.GetApproveParyOnPartyCode(PartyCode, IsSupplier,  Approveid));
        }


        public List<PartyModel> GetAllPartyList(bool IsSupplier)
        {
            return (objRegistrationAPI.GetAllPartyList(IsSupplier));
        }
        public List<ApprovefranchiseList> GetAllAppoveFranchiseList(bool IsSupplier)
        {
            return (objRegistrationAPI.GetAllAppoveFranchiseList(IsSupplier));
        }
        public ResponseDetail IsDuplicatePartyUserName(string IsActionType, string PartyCode, string UserName)
        {
            return (objRegistrationAPI.IsDuplicatePartyUserName(IsActionType,PartyCode,UserName));
        }
        public PartyModel IsDuplicatePartyUserPartyCode(string IsActionType, string PartyCode, string UserName)
        {
            return (objRegistrationAPI.IsDuplicatePartyUserPartyCode(IsActionType, PartyCode, UserName));
        }


        public List<GroupModel> GetGroupList()
        {
            return (objRegistrationAPI.GetGroupList());
        }
    }
}