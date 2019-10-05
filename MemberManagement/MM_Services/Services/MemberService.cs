using Dapper;
using MM_Common.Interface;
using MM_Entities.Entities;
using MM_Services.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MM_Services.Services
{
    public class MemberService : IService<Member>
    {
        private readonly IDapperHelper _dapperHelper;

        public MemberService(IDapperHelper dapperHelper)
        {
            this._dapperHelper = dapperHelper;
        }

        public int Create(Member member)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("MemberTitle", member.MemberTitle, DbType.String);
            dbPara.Add("MemberImage", member.MemberImage, DbType.String);
            dbPara.Add("MemberFirstName", member.MemberFirstName, DbType.String);
            dbPara.Add("MemberLastName", member.MemberLastName, DbType.String);
            dbPara.Add("IsActive", member.IsActive, DbType.String);
            dbPara.Add("CreatedDateTime", DateTime.Now, DbType.DateTime);
            dbPara.Add("UpdatedDateTime", DateTime.Now, DbType.DateTime);

            #region using dapper  
            var data = _dapperHelper.Insert<int>("[dbo].[SP_Add_Member]",
                                dbPara,
                                commandType: CommandType.StoredProcedure);
            return data;
            #endregion

        }

        public Member GetById(int MemberId)
        {
            #region using dapper  
            var data = _dapperHelper.Get<Member>($"select * from member  where MemberId={MemberId}", null,
                    commandType: CommandType.Text);
            return data;
            #endregion
        }

        public int Delete(int MemberId)
        {
            var data = _dapperHelper.Execute($"Delete [Member] where MemberId={MemberId}", null,
                    commandType: CommandType.Text);
            return data;
        }

        public List<Member> ListAll()
        {
            var data = _dapperHelper.GetAll<Member>("[dbo].[SP_Member_List]", null, commandType: CommandType.StoredProcedure);
            return data.ToList();

        }

        public string Update(Member member)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("MemberId", member.MemberID, DbType.Int32);
            dbPara.Add("MemberTitle", member.MemberTitle, DbType.String);
            dbPara.Add("MemberImage", member.MemberImage, DbType.String);
            dbPara.Add("MemberFirstName", member.MemberFirstName, DbType.String);
            dbPara.Add("MemberLastName", member.MemberLastName, DbType.String);
            dbPara.Add("IsActive", member.IsActive, DbType.String);
            dbPara.Add("UpdatedDateTime", DateTime.Now, DbType.DateTime);

            var data = _dapperHelper.Update<string>("[dbo].[SP_Update_Member]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }
    }
}
