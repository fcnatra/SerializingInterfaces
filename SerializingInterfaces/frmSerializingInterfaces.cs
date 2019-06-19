using SerializingInterfaces.Domain;
using SerializingInterfaces.Entities;
using SerializingInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SerializingInterfaces
{
    public partial class frmSerializingInterfaces : Form
    {
        public frmSerializingInterfaces()
        {
            InitializeComponent();
            DoSerializationOperations();
        }

        private void DoSerializationOperations()
        {
            var userDomain = new UserDomain();

            var user = userDomain.CreateUser();


            txtSource.Text = GetOriginalData(user);

            var userFullSerialized = userDomain.SerializeUserFull(user);
            txtSerialized.Text = userFullSerialized;

            var userFullDeserialized = userDomain.DeserializeUserFull(userFullSerialized);
            txtDeserialization1.Text = GetOriginalData(userFullDeserialized);

            var userInfoDeserialized = userDomain.DeserializeUserInfo(userFullSerialized);
            txtDeserialization2.Text = GetUserInfo(userInfoDeserialized);

            var userPersonalDataDeserialized = userDomain.DeserializePersonalData(userFullSerialized);
            txtDeserialization3.Text = GetPersonalData(userPersonalDataDeserialized);

            var userInterestsDeserialized = userDomain.DeserializeInterests(userFullSerialized);
            txtDeserialization4.Text = GetInterests(userInterestsDeserialized);
        }

        private string GetInterests(IEnumerable<IInterestsInfo> interests)
        {
            var content =
                $" Interests:\r\n";

            var preContent = "   ";
            content += GetInterestsTree(interests, preContent) + "\r\n";

            return content;
        }

        private string GetPersonalData(IPersonalDataContainer user)
        {
            var content =
            $"      Name: {user.Name}\r\n" +
            $"   Surname: {user.SurName}\r\n" +
            $" Full name: {user.FullName}\r\n" +
            $"Birth date: {user.BirthDate.ToShortDateString()}\r\n" +
            $"       Age: {user.Age}\r\n";
            return content;
        }

        private string GetUserInfo(IUserInfo user)
        {
            var content =
                $"        Id: {user.Id}\r\n" +
                $" User name: {user.UserName}\r\n";
            return content;
        }

        private string GetOriginalData(IUserFull user)
        {
            var content =
                GetUserInfo(user) +
                GetPersonalData(user) +
                GetInterests(user.Interests);

            return content;
        }

        private string GetInterestsTree(IEnumerable<IInterestsInfo> interests, string preContent)
        {
            string treeData = string.Empty;
            foreach (var item in interests)
            {
                var isLastItem = (item == interests.Last());
                treeData += $"{preContent} └ {item.Interest}\r\n";
                if (item.Interests?.Any() ?? false)
                {
                    var newPrecontent = preContent + " │ ";
                    treeData += GetInterestsTree(item.Interests, (isLastItem ? "".PadLeft(newPrecontent.Length) : newPrecontent));
                }
            }

            return treeData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
