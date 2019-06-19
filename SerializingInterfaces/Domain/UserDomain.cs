using Newtonsoft.Json;
using SerializingInterfaces.Entities;
using SerializingInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SerializingInterfaces.Domain
{
    public class UserDomain
    {
        public IUserFull CreateUser()
        {
            var user = new UserFull();

            user.Id = GetRandomBetween(0, 32767);
            user.UserName = Environment.UserName.ToLower();

            var userNameParts = Environment.UserName.Split(new char[] { '.' });
            user.Name = GetCamelCaseText(userNameParts[0]);
            if (userNameParts.Length > 1) user.SurName = GetCamelCaseText(userNameParts[1]);
            user.BirthDate = GetRandomBirthDate();

            user.Interests = new System.Collections.Generic.List<InterestInfo>
            {
                new InterestInfo
                {
                    Interest = "Philosopfy",
                    Interests = new List<InterestInfo>
                    {
                        new InterestInfo("Behavior"),
                        new InterestInfo("Communications")
                    }
                },
                new InterestInfo
                {
                    Interest = "Music",
                    Interests = new List<InterestInfo>
                    {
                        new InterestInfo("Jazz"),
                        new InterestInfo("Pop"),
                        new InterestInfo("Rock")
                        {
                            Interests = new List<InterestInfo>
                            {
                                new InterestInfo("Heavy"),
                                new InterestInfo("Symphonic")
                            }
                        },
                        new InterestInfo("Classic"),
                        new InterestInfo("Rap"),
                        new InterestInfo("New age"),
                    }
                },
                new InterestInfo
                {
                    Interest = "Sports",
                    Interests = new List<InterestInfo>
                    {
                        new InterestInfo("Running"),
                        new InterestInfo("Body building"),
                        new InterestInfo("Tennis"),
                        new InterestInfo("Horses"),
                        new InterestInfo("Football")
                        {
                            Interests = new List<InterestInfo>
                            {
                                new InterestInfo("American"),
                                new InterestInfo("Soccer")
                            }
                        },
                        new InterestInfo("Baseball"),
                    }
                }
            };

            return user;
        }

        public string SerializeUserFull(IUserFull user)
        {
            string userData = JsonConvert.SerializeObject(user);

            return userData;
        }

        public IUserFull DeserializeUserFull(string userData)
        {
            IUserFull userFull = JsonConvert.DeserializeObject<UserFull>(userData);

            return userFull;
        }

        public IUserInfo DeserializeUserInfo(string userData)
        {
            IUserInfo userInfo = JsonConvert.DeserializeObject<UserFull>(userData);

            return userInfo;
        }

        public IPersonalDataContainer DeserializePersonalData(string userData)
        {
            IPersonalDataContainer personalData = JsonConvert.DeserializeObject<UserFull>(userData);

            return personalData;
        }

        public List<IInterestsInfo> DeserializeInterests(string userData)
        {
            List<IInterestsInfo> personalData = JsonConvert.DeserializeObject<UserFull>(userData).Interests.Cast<IInterestsInfo>().ToList();

            return personalData;
        }

        private DateTime GetRandomBirthDate()
        {
            return new DateTime(DateTime.Now.Year - GetRandomBetween(25, 57), GetRandomBetween(1, 12), GetRandomBetween(1, 28));
        }

        private int GetRandomBetween(int min, int max)
        {
            return (new Random()).Next(min, max);
        }

        private string GetCamelCaseText(string originalText)
        {
            return originalText[0].ToString().ToUpper() + originalText.Substring(1).ToLower().Trim();
        }
    }
}
