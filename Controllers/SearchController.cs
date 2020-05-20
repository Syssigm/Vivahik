using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using VivahikSearchApi.Models;

namespace VivahikSearchApi.Controllers
{

    public class SearchController : ApiController
    {
        private dbVivahik db = new dbVivahik();

        Matuser_Profile custregister = new Matuser_Profile();
        Matuser_Login custlogin = new Matuser_Login();
        Matuser_Address custcontact = new Matuser_Address();
        Matuser_BackgroundPersonalityInterests cusbackgpersontraits = new Matuser_BackgroundPersonalityInterests();
        Matuser_Caste cusmatusercaste = new Matuser_Caste();
        Matuser_ReligionProfile cusmatuserreligionprofile = new Matuser_ReligionProfile();
        Matuser_PhysicalProfile cusmatuserphysicalprofile = new Matuser_PhysicalProfile();
        Matuser_PhysicalStatus cusmatuserphysicalstatus = new Matuser_PhysicalStatus();
        Matuser_ComplexionProfile cusmatusercomplexion = new Matuser_ComplexionProfile();
        Matuser_HeightProfile cusmatuserheight = new Matuser_HeightProfile();
        Matuser_WeightProfile cusmatuserweight = new Matuser_WeightProfile();
        Matuser_AgeRange cusmatuseragerange = new Matuser_AgeRange();
        Matuser_Astrologicalprofile cusmatuserastprofile = new Matuser_Astrologicalprofile();
        Matuser_Occupationalprofile cusmatuseroccprofile = new Matuser_Occupationalprofile();
        Matuser_HabitProfile cusmatuserhabitprofile = new Matuser_HabitProfile();
        Matuser_FamilyProfile cusmatuserfamilyprof = new Matuser_FamilyProfile();
        Matuser_Plan cusmatuserplan = new Matuser_Plan();
        Matuser_Photo cusmatuserphoto = new Matuser_Photo();
        Matuser_ResidentStatus cusmatuserresident = new Matuser_ResidentStatus();
        Matuser_Employmentprofile cusmatuserempprofile = new Matuser_Employmentprofile();

        string Randomnumber = string.Empty;

        // GET: api/Search
        public IQueryable<Matuser_Profile> GetMatruser_Profile()
        {
            return db.Matuser_Profile;
        }

        public IQueryable<Matuser_Profile> GetMatrsrchuser_Profile()
        {
            return db.Matuser_Profile;
        }

        object Editdropdownval = null;

        public void Editprofileheight()
        {
            Editdropdownval = (from r in db.Matuser_HeightProfile
                               select new { r.Matuser_ProfileheightID, r.Matuser_Profileheightinftinches, r.Matuser_Profileheightincms }).ToList();
        }
        public void Editprofileeducate()
        {
            Editdropdownval = (from q in db.Matuser_Educationalprofile
                               select new { q.MatUser_EducationalID, q.Matuser_highestqualification }).ToList();

        }

        public void Editprofilelanguage()
        {
            Editdropdownval = (from s in db.Matuser_UserLanguage
                               select new { s.Matuser_MotherTongueID, s.Matuser_MotherTongueLanguage }).ToList();

        }

        public void Editprofilecountry()
        {
            Editdropdownval = (from t in db.Matuser_Country
                               select new { t.CountryID, t.CountryName }).ToList();

        }

        public void Editprofilereligion()
        {
            Editdropdownval = (from u in db.Matuser_Religion
                               select new { u.Matuser_ReligionID, u.Matuser_Religionname }).ToList();

        }

        public void Editprofilefamvalues()
        {
            Editdropdownval = (from l in db.MatuserFamily_Values
                               select new { l.Matuser_Familyvalues, l.Matuser_FamilyValuesID }).ToList();

        }
        public void Editprofilefamstatus()
        {
            Editdropdownval = (from j in db.MatuserFamily_Status
                               select new { j.Matuser_FamilyStatusID, j.Matuser_FamilyStatus }).ToList();

        }

        public void Editprofilefathstatus()
        {
            Editdropdownval = (from n in db.Matuser_FatherStatus
                               select new { n.Matuser_FatherstatusID, n.Matuser_Fatherstatusdesc }).ToList();

        }

        [Route("api/Search/GetEditdropdownvalues")]
        public IHttpActionResult GetEditdropdownvalues(string custpagnamedrop)
        {
            if (custpagnamedrop == "Editprofileheight")
            {
                Editprofileheight();
            }
            else if (custpagnamedrop == "Editprofileeducate")
            {
                Editprofileeducate();
            }
            else if (custpagnamedrop == "Editprofilelanguage")
            {
                Editprofilelanguage();
            }
            else if (custpagnamedrop == "Editprofilecountry")
            {
                Editprofilecountry();
            }
            else if (custpagnamedrop == "Editprofilereligion")
            {
                Editprofilereligion();
            }
            else if (custpagnamedrop == "Editprofilefamvalues")
            {
                Editprofilefamvalues();
            }
            else if (custpagnamedrop == "Editprofilefamstatus")
            {
                Editprofilefamstatus();
            }
            else if (custpagnamedrop == "Editprofilefathstatus")
            {
                Editprofilefathstatus();
            }
            return Ok(Editdropdownval);
        }

        object dropdownval;

        public void IndexMatrimony()
        {
            dropdownval = (from q in db.Matuser_UserLanguage
                           from p in db.Matuser_Religion
                           from r in db.Matuser_AgeRange
                           select new { q.Matuser_MotherTongueID, q.Matuser_MotherTongueLanguage, p.Matuser_ReligionID, p.Matuser_Religionname, r.Matuser_Loweragelimit, r.Matuser_AgeRangeID }).ToList().Distinct();

        }

        public void Registratation()
        {
            dropdownval = (from q in db.Matuser_Profilefor
                           from p in db.Matuser_Cntrycode
                           select new { q.MatUser_ProfileForID, q.ProfileforName, p.CntID, p.CountryID, p.CountryCode }).ToList().Distinct();

        }

        public void Editprofilemaritalstatus()
        {
            dropdownval = (from z in db.Matuser_Maritalstatus
                           select new { z.MatUser_MaritalStatusID, z.Matuser_MaritalStatusdesc }).ToList();

        }

        public void Editprofilephysicalstatus()
        {
            dropdownval = (from a in db.Matuser_PhysicalStatus
                           select new { a.Matuser_ProfilephysicalstatusID, a.Matuser_Profilephysicalstatusdesc }).ToList();

        }

        public void Editprofileeatingstatus()
        {
            dropdownval = (from b in db.Matuser_EatingStatus
                           select new { b.Matuser_EatingID, b.Matuser_EatingStatusdesc }).ToList();

        }

        public void Editprofiledrinkingstatus()
        {
            dropdownval = (from c in db.Matuser_DrinkingStatus
                           select new { c.Matuser_DrinkingID, c.Matuser_DrinkingStatusdesc }).ToList();

        }

        public void Editprofilesmokingstatus()
        {
            dropdownval = (from d in db.Matuser_SmokingStatus
                           select new { d.Matuser_SmokingID, d.Matuser_SmokingStatusdesc }).ToList();

        }

        public void Editprofilestarstatus()
        {
            dropdownval = (from e in db.Matuser_Star
                           select new { e.Matuser_ProfileStarID, e.Matuser_ProfileStarName}).ToList();

        }

        

        public void Editprofilebodytype()
        {
            dropdownval = (from g in db.Matuser_BodyType
                           select new { g.Matuser_BodyTypeID, g.Matuser_BodyTypeDesc }).ToList();

        }

        public void Editprofilecomplexion()
        {
            dropdownval = (from h in db.Matuser_ComplexionProfile
                           select new { h.Matuser_ProfilecomplexionID, h.Matuser_Profilecomplexionname }).ToList();

        }

        public void Editprofileemployment()
        {
            dropdownval = (from i in db.Matuser_EmploymentMaster
                           select new { i.Matuser_EmploymentMasterID, i.Matuser_Employmentdetails }).ToList();

        }

        public void Editprofilefamtype()
        {
            dropdownval = (from f in db.MatuserFamily_Type
                           select new { f.Matuser_FamilyTypeID, f.Matuser_FamilyType, f.Matuser_FamilyProfile }).ToList();

        }




        [Route("api/Search/GetdropdownvaluesOne")]
        public IHttpActionResult GetdropdownvaluesOne(string custpagnamedrop)
        {

            if (custpagnamedrop == "Editprofilefamtype")
            {
                Editprofilefamtype();
            }
            else if (custpagnamedrop == "Editprofilebodytype")
            {
                Editprofilebodytype();
            }
            else if (custpagnamedrop == "Editprofilecomplexion")
            {
                Editprofilecomplexion();
            }
            else if (custpagnamedrop == "Editprofileemployment")
            {
                Editprofileemployment();
            }
            return Ok(dropdownval);
        }

        [Route("api/Search/Getdropdownvalues")]
        public IHttpActionResult Getdropdownvalues(string custpagnamedrop)
        {
            try
            {
                //object x = null;
                //var dropdownval = x;

                if (custpagnamedrop == "IndexMatrimony")
                {
                    IndexMatrimony();
                }
                else if (custpagnamedrop == "Registratation")
                {
                    Registratation();
                    }
                else if (custpagnamedrop == "Editprofilemaritalstatus")
                {
                    Editprofilemaritalstatus();
                    }
                else if (custpagnamedrop == "Editprofilephysicalstatus")
                {
                    Editprofilephysicalstatus();
                    }
                else if (custpagnamedrop == "Editprofileeatingstatus")
                {
                    Editprofileeatingstatus();
                    }
                else if (custpagnamedrop == "Editprofiledrinkingstatus")
                {
                    Editprofiledrinkingstatus();
                    }
                else if (custpagnamedrop == "Editprofilesmokingstatus")
                {
                    Editprofilesmokingstatus();
                    }
                else if (custpagnamedrop == "Editprofilestarstatus")
                {
                    Editprofilestarstatus();
                    }
                
                
                return Ok(dropdownval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Search/5
        [ResponseType(typeof(Matuser_Profile))]
        [Route("api/Search/GetMatruser_Profile")]
        public IHttpActionResult GetMatruser_Profile(int id)
        {
            Matuser_Profile matruser_Profile = db.Matuser_Profile.Find(id);

            if (matruser_Profile == null)
            {
                return NotFound();
            }

            return Ok(matruser_Profile);
        }

        [Route("api/Search/AdvanceSearchProfile")]
        [HttpPost]
        public IHttpActionResult AdvanceSearchProfile(basicSearch bsd)
        {
            var search = (from q in db.Matuser_Profile
                          join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                          join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                          join u in db.Matuser_Religion on r.Matuser_ReligionID equals u.Matuser_ReligionID
                          join s in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals s.Matuser_PhysicalProfileID
                          join v in db.Matuser_HeightProfile on s.Matuser_ProfileheightID equals v.Matuser_ProfileheightID
                          join w in db.Matuser_Maritalstatus on q.MatUser_MaritalStatusID equals w.MatUser_MaritalStatusID
                          join x in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals x.Matuser_MotherTongueID
                          join d in db.Matuser_Occupationalprofile on q.MatUser_OccupationalID equals d.MatUser_OccupationalID
                          join f in db.Matuser_Educationalprofile on d.Matuser_EducationalID equals f.MatUser_EducationalID
                          join t in db.Matuser_Astrologicalprofile on q.MatUser_AstrologicalID equals t.Matuser_ProfileAstrologicalID
                          join z in db.Matuser_Address on q.MatUser_ProfileaddressID equals z.MatUser_ProfileaddressID
                          //join c in db.Matuser_ResidentStatus on q.Matuser_ResidentstatusID equals c.Matuser_ResidentstatusID
                          join h in db.Matuser_HabitProfile on q.MatUser_HabitualID equals h.MatUser_HabitualID
                          join i in db.Matuser_EatingStatus on h.Matuser_EatingID equals i.Matuser_EatingID
                          join j in db.Matuser_DrinkingStatus on h.Matuser_DrinkingID equals j.Matuser_DrinkingID
                          join k in db.Matuser_SmokingStatus on h.Matuser_SmokingID equals k.Matuser_SmokingID
                          join m in db.Matuser_Photo on q.Matuser_PhotoID equals m.Matuser_PhotoID
                          join n in db.Matuser_Login on q.MatUser_LoginID equals n.MatUser_LoginID
                          //join l in db.Matuser_BackgroundPersonalityInterests on q.MatUser_ProfileID equals l.Matuser_ProfileID

                          where DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) >= bsd.fromAge && DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) <= bsd.toAge
                          where u.Matuser_ReligionID == bsd.Matuser_ReligionID
                          where r.Matuser_Castename == bsd.Matuser_Castename
                          where p.Matuser_SubcasteName == bsd.Matuser_SubcasteName
                          where p.Matuser_GothraName == bsd.Matuser_GothraName
                          where v.Matuser_ProfileheightID >= bsd.nMinHeightID && v.Matuser_ProfileheightID <= bsd.nMaxHeightID
                          where w.MatUser_MaritalStatusID == bsd.MatUser_MaritalStatusID
                          where x.Matuser_MotherTongueID == bsd.MatUser_MotherTongueID
                          where s.Matuser_ProfilephysicalstatusID == bsd.Matuser_ProfilephysicalstatusID

                          where z.CntID == bsd.CountryID
                          //where z.State == bsd.State.Trim()
                          //where z.CityName == bsd.CityName.Trim()
                          //where c.Matuser_ResidentstatusID == bsd.ResidentstatusID
                          where f.MatUser_EducationalID == bsd.Matuser_EducationalID
                          where d.Matuser_EmploymentID == bsd.MatUser_OccupationalID
                          where t.Matuser_ProfileStarID == bsd.Matuser_ProfileStarID
                          where t.Matuser_Kujadoshamflag == bsd.kujadosham
                          where h.Matuser_EatingID == bsd.Matuser_EatingID
                          where h.Matuser_DrinkingID == bsd.Matuser_DrinkingID
                          where h.Matuser_SmokingID == bsd.Matuser_SmokingID


                          //where l.Matuser_BgAffluentflg == bsd.Affluent
                          //where l.Matuser_BgEnjoysmusicflg == bsd.Enjoysmusic
                          //where l.Matuser_BgWarmFriendlyflg == bsd.WarmFrnd
                          //where l.Matuser_BgCheerfulflg == bsd.Cheerful
                          //where l.Matuser_BgLikesphotographyflg == bsd.Likesphoto
                          //where l.Matuser_BgEnjoysfoodflg == bsd.Enjoyfod
                          //where l.Matuser_BgWelleducatedflg == bsd.Welledu
                          //where l.Matuser_BgSpirituallyinclinedflg == bsd.Spiritual
                          //where l.Matuser_BgAttractiveflg == bsd.Attract
                          //where l.Matuser_BgLovingflg == bsd.Loving
                          //where l.Matuser_BgLikesartflg == bsd.Likart
                          //where l.Matuser_BgLikesnatureflg == bsd.Likenat
                          //where l.Matuser_BgFamilyorientedflg == bsd.Familyori
                          //where l.Matuser_BgHealthconsciousflg == bsd.Health
                          //where l.Matuser_BgTeetotallerflg == bsd.Teet
                          //where l.Matuser_BgCaresforpetsflg == bsd.Cares
                          //where l.Matuser_BgLikesreadingflg == bsd.reading
                          //where l.Matuser_BgLikesliteratureflg == bsd.litera

                          select new
                          {
                              Profileid = q.MatUser_ProfileIDGN,
                              FullName = q.MatUser_FirstName + " " + q.MatUser_LastName,
                              AgeHeight = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs, " + v.Matuser_Profileheightinftinches,
                              Matuser_Religionname = u.Matuser_Religionname,
                              Matuser_MotherTongueLanguage = x.Matuser_MotherTongueLanguage,
                              Matuser_Castename = r.Matuser_Castename,
                              CityName = z.CityName,
                              Matuser_highestqualification = f.Matuser_highestqualification,
                              //Profession = "",
                              Matuser_PhotoURL1 = m.Matuser_PhotoURL1,
                              Matuser_ProfileloginID = n.Matuser_ProfileloginID,
                          }).ToList();
            return Ok(search);
        }

        //http://localhost:49681/api/Search/GetProfileLogin?logind=logind
        [Route("api/Search/GetProfileLogin")]
        public IHttpActionResult GetProfileLogin(string logind)
        {
            try
            {
                var profileDetails = (from q in db.Matuser_Profile
                                      join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                                      join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                                      join s in db.Matuser_Religion on r.Matuser_ReligionID equals s.Matuser_ReligionID
                                      join t in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals t.Matuser_MotherTongueID
                                      join u in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals u.Matuser_PhysicalProfileID
                                      join v in db.Matuser_AgeRange on u.Matuser_AgeRangeID equals v.Matuser_AgeRangeID
                                      join w in db.Matuser_Address on q.MatUser_ProfileaddressID equals w.MatUser_ProfileaddressID
                                      join X in db.Matuser_Occupationalprofile on q.MatUser_OccupationalID equals X.MatUser_OccupationalID
                                      join Y in db.Matuser_Educationalprofile on X.Matuser_EducationalID equals Y.MatUser_EducationalID
                                      join Z in db.Matuser_Employmentprofile on X.Matuser_EmploymentID equals Z.Matuser_EmploymentID
                                      join A in db.Matuser_HeightProfile on u.Matuser_ProfileheightID equals A.Matuser_ProfileheightID
                                      join B in db.Matuser_Photo on q.Matuser_PhotoID equals B.Matuser_PhotoID
                                      join l in db.Matuser_Login on q.MatUser_LoginID equals l.MatUser_LoginID

                                      where l.Matuser_ProfileloginID == logind.Trim()
                                      select new
                                      {
                                          MatUser_FirstName = q.MatUser_FirstName,
                                          MatUser_LastName = q.MatUser_LastName,
                                          Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString(), //+ "Yrs, " + A.Matuser_Profileheightinftinches,
                                          Matuser_Religionname = s.Matuser_Religionname,
                                          Matuser_MotherTongueLanguage = t.Matuser_MotherTongueLanguage,
                                          Matuser_SubcasteName = p.Matuser_SubcasteName,
                                          Matuser_Castename = r.Matuser_Castename,
                                          CityName = w.CityName,
                                          Matuser_highestqualification = Y.Matuser_highestqualification,
                                          Matuser_Employmentdetails = Z.Matuser_Employmentdetails,
                                          Comments = q.Comments,
                                          Matuser_PhotoURL1 = B.Matuser_PhotoURL1,
                                          Matuser_PhotoURL2 = B.Matuser_PhotoURL2,
                                          Matuser_PhotoURL3 = B.Matuser_PhotoURL3,
                                          Matuser_PhotoURL4 = B.Matuser_PhotoURL4,
                                          Matuser_PhotoURL5 = B.Matuser_PhotoURL5,
                                      }).ToList();


                return Ok(profileDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //http://localhost:49681/api/Search/GetMatruser_Profile?gender=Male&fromAge=18&toAge=30&Mothertong=N/A&Religion=Inter-Religion
        // GET: api/Search/5

        //[ResponseType(typeof(Matruser_Profile))]
        [Route("api/Search/Matruser_ProfileDetails")]
        public IHttpActionResult Matruser_ProfileDetails(basicSearch bsd)
        {
            try
            {
                var profile = (from q in db.Matuser_Profile
                               join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                               join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                               join s in db.Matuser_Religion on r.Matuser_ReligionID equals s.Matuser_ReligionID
                               join t in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals t.Matuser_MotherTongueID
                               join u in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals u.Matuser_PhysicalProfileID
                               join v in db.Matuser_AgeRange on u.Matuser_AgeRangeID equals v.Matuser_AgeRangeID
                               join w in db.Matuser_Address on q.MatUser_ProfileaddressID equals w.MatUser_ProfileaddressID
                               join x in db.Matuser_Photo on q.MatUser_ProfileIDGN equals x.MatUser_ProfileIDGN
                               where DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) >= bsd.fromAge && DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) <= bsd.toAge
                               where t.Matuser_MotherTongueLanguage == bsd.Matuser_MotherTongueLanguage
                               where s.Matuser_Religionname == bsd.Matuser_Religionname
                               where q.MatUser_Gender == bsd.MatUser_Gender
                               select new
                               {
                                   ProfileId = q.MatUser_ProfileIDGN,
                                   FullName = q.MatUser_FirstName + " " + q.MatUser_LastName,
                                   MatUser_FirstName = q.MatUser_FirstName,
                                   MatUser_LastName = q.MatUser_LastName,
                                   MatUser_Gender = q.MatUser_Gender,
                                   Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs",
                                   CityName = w.CityName,
                                   Matuser_Castename = r.Matuser_Castename,
                                   q.MatUser_MaritalStatusID,
                                   q.Matuser_PhotoID,
                                   q.MatUser_DOB,
                                   x.Matuser_PhotoURL1,
                                   q.Comments,
                               }).ToList();

                return Ok(profile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Method for fetching the authenticating the login details of the user

        // http://localhost:49681/api/Search/Authenticatelogin?custuserid=a@syssigma.com&custpassw=123

        [HttpGet]
        [Route("api/Search/Authenticatelogin")]
        public IHttpActionResult Authenticatelogin(string custuserid, string custpassw)
        {
            try
            {
                object x = null;
                var loginauth = x;
                loginauth = (from q in db.Matuser_Login
                             where q.Matuser_ProfileloginID == custuserid && q.Matuser_ProfilePassword == custpassw
                             select new { q.MatUser_LoginID, q.Matuser_ProfileloginID, q.Matuser_ProfilePassword }).ToList();
                return Ok(loginauth);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // This method is for getting search results for religion,location,mothertongue and community

        // http://localhost:49681/api/Search/GetMatrsrchuser_Profile?genstring=" + genstring + "stringtype=" + stringtype


        //[ResponseType(typeof(Matruser_Profile))]
        [Route("api/Search/GetMatrsrchuser_Profile")]
        public IHttpActionResult GetMatrsrchuser_Profile(string genstring, string stringtype)
        {
            object x = null;
            var profile = x;
            try
            {

                if (stringtype == "R")
                {
                    profile = (from q in db.Matuser_Profile
                               join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                               join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                               join s in db.Matuser_Religion on r.Matuser_ReligionID equals s.Matuser_ReligionID
                               join w in db.Matuser_Address on q.MatUser_ProfileaddressID equals w.MatUser_ProfileaddressID
                               where s.Matuser_Religionname.Contains(genstring)
                               select new
                               {
                                   ProfileId = q.MatUser_ProfileIDGN,
                                   MatUser_FirstName = q.MatUser_FirstName,
                                   MatUser_LastName = q.MatUser_LastName,
                                   MatUser_Gender = q.MatUser_Gender,
                                   Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs",
                                   CityName = w.CityName,
                                   Matuser_Castename = r.Matuser_Castename,
                                   q.MatUser_MaritalStatusID,
                                   q.Matuser_PhotoID,
                                   q.MatUser_DOB,
                               }).ToList();

                }

                if (stringtype == "L")
                {
                    profile = (from q in db.Matuser_Profile
                               join w in db.Matuser_Address on q.MatUser_ProfileaddressID equals w.MatUser_ProfileaddressID
                               join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                               join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                               where w.CityName.Contains(genstring)
                               select new
                               {
                                   ProfileId = q.MatUser_ProfileIDGN,
                                   MatUser_FirstName = q.MatUser_FirstName,
                                   MatUser_LastName = q.MatUser_LastName,
                                   MatUser_Gender = q.MatUser_Gender,
                                   Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs",
                                   CityName = w.CityName,
                                   Matuser_Castename = r.Matuser_Castename,
                                   q.MatUser_MaritalStatusID,
                                   q.Matuser_PhotoID,
                                   q.MatUser_DOB,
                               }).ToList();
                }

                if (stringtype == "M")
                {
                    profile = (from q in db.Matuser_Profile
                               join t in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals t.Matuser_MotherTongueID
                               join w in db.Matuser_Address on q.MatUser_ProfileaddressID equals w.MatUser_ProfileaddressID
                               join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                               join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                               where t.Matuser_MotherTongueLanguage.Contains(genstring)
                               select new
                               {
                                   ProfileId = q.MatUser_ProfileIDGN,
                                   MatUser_FirstName = q.MatUser_FirstName,
                                   MatUser_LastName = q.MatUser_LastName,
                                   MatUser_Gender = q.MatUser_Gender,
                                   Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs",
                                   CityName = w.CityName,
                                   Matuser_Castename = r.Matuser_Castename,
                                   q.MatUser_MaritalStatusID,
                                   q.Matuser_PhotoID,
                                   q.MatUser_DOB,
                               }).ToList();
                }

                return Ok(profile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //http://localhost:49681/api/Search/GetReligionLists?value=4
        //[ResponseType(typeof(Matruser_Profile))]
        [Route("api/Search/GetReligionLists")]
        public IHttpActionResult GetReligionLists(int value)
        {
            var relign = (from q in db.Matuser_Caste
                          where q.Matuser_ReligionID == value
                          select new
                          {
                              q.Matuser_Castename,
                              q.Matuser_ProfileCasteID
                          }).ToList();
            return Ok(relign);
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        //http://localhost:49681/api/Search/GetRegistratation?emailid=r@gmail.com&PhoneNumberTaggedToAddress=919879183465&FirstName=Raman&LastName=Shetty&DOB=4/12/1995%2012:00:00%20AM&Gender=Male&ProfileforName=Son
        //[HttpPost]
        [Route("api/Search/GetRegistratation")]
        public IHttpActionResult GetRegistratation(String emailid, string PhoneNumberTaggedToAddress, string ProfileforName, string Gender, DateTime DOB, string LastName, string FirstName)
        {
            var DbTrans = db.Database.BeginTransaction();
            string msg = string.Empty;
            int currprofileid;
            try
            {
                string newpassword = CreatePassword(12);
                custlogin.Matuser_ProfileloginID = emailid;
                custlogin.Matuser_ProfilePassword = newpassword;
                db.Matuser_Login.Add(custlogin);

                var vldemail = (from q in db.Matuser_Login
                                where q.Matuser_ProfileloginID == emailid
                                select new { q.Matuser_ProfileloginID }).ToList();

                if (vldemail.Count == 0)
                {
                    custcontact.EmailTaggedToAddress = emailid;
                    custcontact.PhoneNumberTaggedToAddress = PhoneNumberTaggedToAddress;
                    custcontact.AddressType = string.Empty;
                    custcontact.BuildingNumber = string.Empty;
                    custcontact.StreetName1 = string.Empty;
                    custcontact.StreetName2 = string.Empty;
                    custcontact.CityName = string.Empty;
                    custcontact.State = "";
                    custcontact.Zipcode = "";
                    custcontact.CntID = 78;
                    custcontact.AddressStatus = "";
                    custcontact.Registered_ts = System.DateTime.Now;
                    custcontact.Updated_ts = System.DateTime.Now;
                    db.Matuser_Address.Add(custcontact);
                    db.SaveChanges();


                    var matuserprofileid = (from p in db.Matuser_Profilefor
                                            where p.ProfileforName == ProfileforName
                                            select new { p.MatUser_ProfileForID }).Single();

                    var matuseraddressid = (from p in db.Matuser_Address
                                            where p.EmailTaggedToAddress == emailid
                                            select new { p.MatUser_ProfileaddressID }).SingleOrDefault();

                    var loginid = (from q in db.Matuser_Login
                                   where q.Matuser_ProfileloginID == emailid
                                   select new { q.MatUser_LoginID }).SingleOrDefault();

                    Random random = new Random();

                    int n = random.Next(0, 100000);
                    Randomnumber += n.ToString("D5");

                    var prevprofileid = (from q in db.Matuser_Profile
                                         select new { q.MatUser_ProfileID }).ToList();


                    if (prevprofileid.Count == 0)
                    {
                        currprofileid = 1;
                    }
                    else
                    {

                        var currprofileids = db.Matuser_Profile.Select(x => x.MatUser_ProfileID).Max();

                        currprofileid = Convert.ToInt32(currprofileids) + 1;
                    }


                    cusbackgpersontraits.Matuser_ProfileID = currprofileid;
                    cusbackgpersontraits.Matuser_BgAffluentflg = "N";
                    cusbackgpersontraits.Matuser_BgEnjoysmusicflg = "N";
                    cusbackgpersontraits.Matuser_BgWarmFriendlyflg = "N";
                    cusbackgpersontraits.Matuser_BgCheerfulflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesphotographyflg = "N";
                    cusbackgpersontraits.Matuser_BgEnjoysfoodflg = "N";
                    cusbackgpersontraits.Matuser_BgWelleducatedflg = "N";
                    cusbackgpersontraits.Matuser_BgSpirituallyinclinedflg = "N";
                    cusbackgpersontraits.Matuser_BgAttractiveflg = "N";
                    cusbackgpersontraits.Matuser_BgCaresforpetsflg = "N";
                    cusbackgpersontraits.Matuser_BgLovingflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesartflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesnatureflg = "N";
                    cusbackgpersontraits.Matuser_BgFamilyorientedflg = "N";
                    cusbackgpersontraits.Matuser_BgHealthconsciousflg = "N";
                    cusbackgpersontraits.Matuser_BgTeetotallerflg = "N";
                    cusbackgpersontraits.Matuser_BgCaresforpetsflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesreadingflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesliteratureflg = "N";
                    cusbackgpersontraits.Matuser_CreateTS = DateTime.Now;
                    cusbackgpersontraits.Matuser_UpdateTS = DateTime.Now;
                    db.Matuser_BackgroundPersonalityInterests.Add(cusbackgpersontraits);

                    var religionid = (from q in db.Matuser_Religion
                                      where q.Matuser_Religionname == "N/A"
                                      select new { q.Matuser_ReligionID }).SingleOrDefault();



                    cusmatusercaste.Matuser_Castename = "N/A";
                    cusmatusercaste.Matuser_ReligionID = religionid.Matuser_ReligionID;
                    cusmatusercaste.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Caste.Add(cusmatusercaste);
                    db.SaveChanges();

                    cusmatuserweight.Matuser_Profileweightinkgs = 0;
                    cusmatuserweight.Matuser_ProfileweightID = 0;
                    cusmatuserweight.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_WeightProfile.Add(cusmatuserweight);

                    var profilecasteid = (from q in db.Matuser_Caste

                                          where q.MatUser_ProfileIDGN == cusmatusercaste.MatUser_ProfileIDGN
                                          select new { q.Matuser_ProfileCasteID }).SingleOrDefault();

                    cusmatuserreligionprofile.Matuser_ProfileCasteID = profilecasteid.Matuser_ProfileCasteID;
                    cusmatuserreligionprofile.Matuser_GothraName = "N/A";
                    cusmatuserreligionprofile.Matuser_SubcasteName = "N/A";
                    cusmatuserreligionprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;

                    db.Matuser_ReligionProfile.Add(cusmatuserreligionprofile);
                    db.SaveChanges();



                    var ProfileRelCastSubcastID = (from q in db.Matuser_ReligionProfile
                                                   where q.MatUser_ProfileIDGN == cusmatuserreligionprofile.MatUser_ProfileIDGN
                                                   //where q.Matuser_GothraName == cusmatuserreligionprofile.Matuser_GothraName
                                                   //where q.Matuser_SubcasteName == cusmatuserreligionprofile.Matuser_SubcasteName
                                                   select new { q.MatUser_ProfileRelCastSubcastID }).SingleOrDefault();



                    var profilelanguadeid = (from q in db.Matuser_UserLanguage
                                             where q.Matuser_MotherTongueLanguage == "N/A"
                                             select new { q.Matuser_MotherTongueID }).SingleOrDefault();

                    var profilemarstatid = (from q in db.Matuser_Maritalstatus
                                            where q.Matuser_MaritalStatusdesc == "N/A"
                                            select new { q.MatUser_MaritalStatusID }).SingleOrDefault();


                    var profilephystat = (from q in db.Matuser_PhysicalStatus
                                          where q.Matuser_Profilephysicalstatusdesc == "N/A"
                                          select new { q.Matuser_ProfilephysicalstatusID }).SingleOrDefault();

                    var profilecomplex = (from q in db.Matuser_ComplexionProfile
                                          where q.Matuser_Profilecomplexionname == "N/A"
                                          select new { q.Matuser_ProfilecomplexionID }).SingleOrDefault();

                    var profileheight = (from q in db.Matuser_HeightProfile
                                         where q.Matuser_Profileheightincms == 0
                                         where q.Matuser_Profileheightinftinches == "0"
                                         select new { q.Matuser_ProfileheightID }).SingleOrDefault();

                    var profilewightid = (from q in db.Matuser_WeightProfile
                                          where q.MatUser_ProfileIDGN == cusmatuserweight.MatUser_ProfileIDGN
                                          //where q.Matuser_Profileweightinlbs == 0
                                          select new { q.Matuser_ProfileweightID }).SingleOrDefault();

                    var profileagerange = (from q in db.Matuser_AgeRange
                                           where q.Matuser_Loweragelimit == 18
                                           select new { q.Matuser_AgeRangeID }).SingleOrDefault();


                    cusmatuserphysicalprofile.Matuser_AgeRangeID = profileagerange.Matuser_AgeRangeID;
                    cusmatuserphysicalprofile.Matuser_ProfilephysicalstatusID = profilephystat.Matuser_ProfilephysicalstatusID;
                    cusmatuserphysicalprofile.Matuser_ProfilecomplexionID = profilecomplex.Matuser_ProfilecomplexionID;
                    cusmatuserphysicalprofile.Matuser_ProfileheightID = profileheight.Matuser_ProfileheightID;
                    cusmatuserphysicalprofile.Matuser_ProfileweightID = profilewightid.Matuser_ProfileweightID;
                    cusmatuserphysicalprofile.Matuser_BodyTypeID = 1;
                    cusmatuserphysicalprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_PhysicalProfile.Add(cusmatuserphysicalprofile);
                    db.SaveChanges();

                    var profilephysicdetid = (from q in db.Matuser_PhysicalProfile
                                              where q.MatUser_ProfileIDGN == cusmatuserphysicalprofile.MatUser_ProfileIDGN
                                              //where q.Matuser_ProfilecomplexionID == profilecomplex.Matuser_ProfilecomplexionID
                                              //where q.Matuser_ProfileheightID == profileheight.Matuser_ProfileheightID
                                              //where q.Matuser_ProfileweightID == profilewightid.Matuser_ProfileweightID
                                              select new { q.Matuser_PhysicalProfileID }).SingleOrDefault();

                    var cusmatuserraasi = (from q in db.Matuser_Raasi
                                           where q.Matuser_ProfileRaasiName == "N/A"
                                           select new { q.Matuser_ProfileRaasiID }).SingleOrDefault();

                    var cusmatuserstar = (from q in db.Matuser_Star
                                          where q.Matuser_ProfileStarName == "N/A"
                                          select new { q.Matuser_ProfileStarID }).SingleOrDefault();

                    cusmatuserastprofile.Matuser_ProfileRaasiID = cusmatuserraasi.Matuser_ProfileRaasiID;
                    cusmatuserastprofile.Matuser_ProfileStarID = cusmatuserstar.Matuser_ProfileStarID;
                    cusmatuserastprofile.Matuser_Kujadoshamflag = "N";
                    cusmatuserastprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Astrologicalprofile.Add(cusmatuserastprofile);
                    db.SaveChanges();

                    cusmatuserempprofile.EmployerName = "N/A";
                    cusmatuserempprofile.Matuser_SalaryinLakhrupees = 0;
                    cusmatuserempprofile.Matuser_Employmentdetails = "N/A";
                    cusmatuserempprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Employmentprofile.Add(cusmatuserempprofile);
                    db.SaveChanges();

                    var cusprofileastroid = (from q in db.Matuser_Astrologicalprofile
                                             where q.MatUser_ProfileIDGN == cusmatuserastprofile.MatUser_ProfileIDGN
                                             //where q.Matuser_ProfileRaasiID == cusmatuserraasi.Matuser_ProfileRaasiID
                                             select new { q.Matuser_ProfileAstrologicalID }).SingleOrDefault();

                    var cusmatusereduid = (from q in db.Matuser_Educationalprofile
                                           where q.Matuser_highestqualification == "N/A"
                                           select new { q.MatUser_EducationalID }).SingleOrDefault();

                    var cusmatuserempid = (from q in db.Matuser_Employmentprofile
                                           where q.MatUser_ProfileIDGN == cusmatuserempprofile.MatUser_ProfileIDGN
                                           select new { q.Matuser_EmploymentID }).SingleOrDefault();

                    cusmatuseroccprofile.Matuser_EducationalID = cusmatusereduid.MatUser_EducationalID;
                    cusmatuseroccprofile.Matuser_EmploymentID = cusmatuserempid.Matuser_EmploymentID;
                    cusmatuseroccprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Occupationalprofile.Add(cusmatuseroccprofile);
                    db.SaveChanges();

                    var profileoccupationid = (from q in db.Matuser_Occupationalprofile
                                               where q.MatUser_ProfileIDGN == cusmatuseroccprofile.MatUser_ProfileIDGN
                                               //where q.Matuser_EmploymentID == cusmatuserempid.Matuser_EmploymentID
                                               select new { q.MatUser_OccupationalID }).SingleOrDefault();

                    var drinkingstatus = (from q in db.Matuser_DrinkingStatus
                                          where q.Matuser_DrinkingStatusdesc == "N/A"
                                          select new { q.Matuser_DrinkingID }).SingleOrDefault();

                    var smokingstatus = (from q in db.Matuser_SmokingStatus
                                         where q.Matuser_SmokingStatusdesc == "N/A"
                                         select new { q.Matuser_SmokingID }).SingleOrDefault();

                    var eatingstatus = (from q in db.Matuser_EatingStatus
                                        where q.Matuser_EatingStatusdesc == "N/A"
                                        select new { q.Matuser_EatingID }).SingleOrDefault();

                    cusmatuserhabitprofile.Matuser_DrinkingID = drinkingstatus.Matuser_DrinkingID;
                    cusmatuserhabitprofile.Matuser_SmokingID = smokingstatus.Matuser_SmokingID;
                    cusmatuserhabitprofile.Matuser_EatingID = eatingstatus.Matuser_EatingID;
                    cusmatuserhabitprofile.Create_ts = System.DateTime.Now;
                    cusmatuserhabitprofile.Update_ts = System.DateTime.Now;
                    cusmatuserhabitprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_HabitProfile.Add(cusmatuserhabitprofile);
                    db.SaveChanges();

                    var profilehabitid = (from q in db.Matuser_HabitProfile
                                          where q.MatUser_ProfileIDGN == cusmatuserhabitprofile.MatUser_ProfileIDGN
                                          //where q.Matuser_EatingID == eatingstatus.Matuser_EatingID
                                          //where q.Matuser_SmokingID == smokingstatus.Matuser_SmokingID
                                          select new { q.MatUser_HabitualID }).SingleOrDefault();


                    var familyvalu = (from q in db.MatuserFamily_Values
                                      where q.Matuser_Familyvalues == "N/A"
                                      select new { q.Matuser_FamilyValuesID }).SingleOrDefault();
                    var famliytyp = (from q in db.MatuserFamily_Type
                                     where q.Matuser_FamilyType == "N/A"
                                     select new { q.Matuser_FamilyTypeID }).SingleOrDefault();
                    var familystat = (from q in db.MatuserFamily_Status
                                      where q.Matuser_FamilyStatus == "N/A"
                                      select new { q.Matuser_FamilyStatusID }).SingleOrDefault();

                    cusmatuserfamilyprof.Matuser_FamilyStatusID = familystat.Matuser_FamilyStatusID;
                    cusmatuserfamilyprof.Matuser_FamilyValuesID = familyvalu.Matuser_FamilyValuesID;
                    cusmatuserfamilyprof.Matuser_FamilyTypeID = famliytyp.Matuser_FamilyTypeID;
                    cusmatuserfamilyprof.Matuser_FatherstatusID = 4;
                    cusmatuserfamilyprof.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_FamilyProfile.Add(cusmatuserfamilyprof);
                    db.SaveChanges();

                    var profilefamlydetid = (from q in db.Matuser_FamilyProfile
                                             where q.MatUser_ProfileIDGN == cusmatuserfamilyprof.MatUser_ProfileIDGN
                                             //where q.Matuser_FamilyValuesID == familyvalu.Matuser_FamilyValuesID
                                             //where q.Matuser_FamilyTypeID == famliytyp.Matuer_FamilyTypeID
                                             select new { q.MatUser_FamilydetID }).SingleOrDefault();


                    cusmatuserplan.Matuser_Planname = "N/A";
                    cusmatuserplan.Matuser_Planperioddays = 0;
                    cusmatuserplan.Matuser_PriceinUSD = 0;
                    cusmatuserplan.Matuser_PriceinINR = 0;
                    cusmatuserplan.Matuser_Planstartdate = System.DateTime.Now;
                    cusmatuserplan.Matuser_Planenddate = System.DateTime.Now;
                    cusmatuserplan.Matuser_activeflag = "N";
                    cusmatuserplan.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    cusmatuserplan.Create_ts = System.DateTime.Now;
                    cusmatuserplan.Update_ts = System.DateTime.Now;

                    db.Matuser_Plan.Add(cusmatuserplan);
                    db.SaveChanges();

                    var profileplan = (from q in db.Matuser_Plan
                                           //where q.Matuser_Planname == "N/A"
                                           //where q.Matuser_Planperioddays == 0
                                           //where q.Matuser_PriceinINR == 0
                                           //where q.Matuser_PriceinUSD == 0
                                       where q.MatUser_ProfileIDGN == cusmatuserplan.MatUser_ProfileIDGN

                                       select new { q.Matuser_PlanID }).SingleOrDefault();


                    cusmatuserphoto.Matuser_Phototititle = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL1 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL2 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL3 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL4 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL5 = "N/A";
                    cusmatuserphoto.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    cusmatuserphoto.Create_ts = System.DateTime.Now;
                    cusmatuserphoto.Update_ts = System.DateTime.Now;

                    db.Matuser_Photo.Add(cusmatuserphoto);
                    db.SaveChanges();

                    var profilephoto = (from q in db.Matuser_Photo
                                            //where q.Matuser_Phototititle == "N/A"
                                            //where q.Matuser_PhotoURL1 == "N/A"
                                            //where q.Matuser_PhotoURL3 == "N/A"
                                            //where q.Matuser_PhotoURL2 == "N/A"
                                            //where q.Matuser_PhotoURL4 == "N/A"
                                            //where q.Matuser_PhotoURL5 == "N/A"
                                        where q.MatUser_ProfileIDGN == cusmatuserphoto.MatUser_ProfileIDGN
                                        select new { q.Matuser_PhotoID }).SingleOrDefault();

                    var cusresidentstat = (from q in db.Matuser_ResidentStatus
                                           where q.Matuser_Residentstatusdesc == "N/A"
                                           select new { q.Matuser_ResidentstatusID }).SingleOrDefault();


                    int cuslogid = loginid.MatUser_LoginID;
                    custregister.MatUser_LoginID = cuslogid;
                    custregister.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    custregister.MatUser_ProfileForID = Convert.ToInt32(matuserprofileid.MatUser_ProfileForID);
                    custregister.MatUser_ProfileaddressID = Convert.ToInt32(matuseraddressid.MatUser_ProfileaddressID);
                    custregister.MatUser_FirstName = FirstName;
                    custregister.MatUser_LastName = LastName;
                    custregister.MatUser_DOB = DOB;
                    custregister.MatUser_Gender = Gender;
                    custregister.MatUser_ProfileRelCastSubcastID = ProfileRelCastSubcastID.MatUser_ProfileRelCastSubcastID;
                    custregister.MatUser_MotherTongueID = profilelanguadeid.Matuser_MotherTongueID;
                    custregister.MatUser_MaritalStatusID = profilemarstatid.MatUser_MaritalStatusID;
                    custregister.MatUser_PhysicaldetID = profilephysicdetid.Matuser_PhysicalProfileID;
                    custregister.MatUser_AstrologicalID = cusprofileastroid.Matuser_ProfileAstrologicalID;
                    custregister.MatUser_OccupationalID = profileoccupationid.MatUser_OccupationalID;
                    custregister.MatUser_HabitualID = profilehabitid.MatUser_HabitualID;
                    custregister.MatUser_FamilydetID = profilefamlydetid.MatUser_FamilydetID;
                    custregister.MatUser_PlanID = profileplan.Matuser_PlanID;
                    custregister.Matuser_PhotoID = profilephoto.Matuser_PhotoID;
                    custregister.Comments = "";
                    custregister.Create_ts = DateTime.Now;
                    custregister.Update_ts = DateTime.Now;
                    db.Matuser_Profile.Add(custregister);
                    db.SaveChanges();
                    //lblmsg.Text = "Customer Details Saved Successfully, User ID details mailed";
                    //lblmsg.ForeColor = System.Drawing.Color.White;

                    DbTrans.Commit();

                    var password = (from q in db.Matuser_Login
                                    where q.Matuser_ProfileloginID == emailid
                                    select new { q.Matuser_ProfileloginID, q.Matuser_ProfilePassword }).ToList();


                    return Ok(password);
                }
                else
                {
                    List<Error> flg = new List<Error>();
                    flg.Add(new Error { ErrormsgOrflg = "N" });
                    return Ok(flg);
                }
            }

            catch (Exception ex)
            {
                DbTrans.Rollback();
                List<Error> flg = new List<Error>();
                flg.Add(new Error { ErrormsgOrflg = ex.Message });
                return Ok(flg);
            }

        }

        [HttpPost]
        [Route("api/Search/Registratation")]
        public IHttpActionResult Registratation(basicSearch bsd)
        {
            var DbTrans = db.Database.BeginTransaction();
            string msg = string.Empty;
            int currprofileid;
            try
            {
                string newpassword = CreatePassword(12);
                custlogin.Matuser_ProfileloginID = bsd.EmailTaggedToAddress;
                custlogin.Matuser_ProfilePassword = newpassword;
                db.Matuser_Login.Add(custlogin);

                var vldemail = (from q in db.Matuser_Login
                                where q.Matuser_ProfileloginID == bsd.EmailTaggedToAddress
                                select new { q.Matuser_ProfileloginID }).ToList();

                if (vldemail.Count == 0)
                {
                    custcontact.EmailTaggedToAddress = bsd.EmailTaggedToAddress;
                    custcontact.PhoneNumberTaggedToAddress = bsd.PhoneNumberTaggedToAddress;
                    custcontact.AddressType = string.Empty;
                    custcontact.BuildingNumber = string.Empty;
                    custcontact.StreetName1 = string.Empty;
                    custcontact.StreetName2 = string.Empty;
                    custcontact.CityName = string.Empty;
                    custcontact.State = "";
                    custcontact.Zipcode = "";
                    custcontact.CntID = 78;
                    custcontact.AddressStatus = "";
                    custcontact.Registered_ts = System.DateTime.Now;
                    custcontact.Updated_ts = System.DateTime.Now;
                    db.Matuser_Address.Add(custcontact);
                    db.SaveChanges();

                    var matuserprofileid = (from p in db.Matuser_Profilefor
                                            where p.ProfileforName == bsd.ProfileforName
                                            select new { p.MatUser_ProfileForID }).Single();

                    var matuseraddressid = (from p in db.Matuser_Address
                                            where p.EmailTaggedToAddress == bsd.EmailTaggedToAddress
                                            select new { p.MatUser_ProfileaddressID }).SingleOrDefault();

                    var loginid = (from q in db.Matuser_Login
                                   where q.Matuser_ProfileloginID == bsd.EmailTaggedToAddress
                                   select new { q.MatUser_LoginID }).SingleOrDefault();

                    Random random = new Random();

                    int n = random.Next(0, 100000);
                    Randomnumber += n.ToString("D5");

                    var prevprofileid = (from q in db.Matuser_Profile
                                         select new { q.MatUser_ProfileID }).ToList();


                    if (prevprofileid.Count == 0)
                    {
                        currprofileid = 1;
                    }
                    else
                    {

                        var currprofileids = db.Matuser_Profile.Select(x => x.MatUser_ProfileID).Max();

                        currprofileid = Convert.ToInt32(currprofileids) + 1;
                    }


                    cusbackgpersontraits.Matuser_ProfileID = currprofileid;
                    cusbackgpersontraits.Matuser_BgAffluentflg = "N";
                    cusbackgpersontraits.Matuser_BgEnjoysmusicflg = "N";
                    cusbackgpersontraits.Matuser_BgWarmFriendlyflg = "N";
                    cusbackgpersontraits.Matuser_BgCheerfulflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesphotographyflg = "N";
                    cusbackgpersontraits.Matuser_BgEnjoysfoodflg = "N";
                    cusbackgpersontraits.Matuser_BgWelleducatedflg = "N";
                    cusbackgpersontraits.Matuser_BgSpirituallyinclinedflg = "N";
                    cusbackgpersontraits.Matuser_BgAttractiveflg = "N";
                    cusbackgpersontraits.Matuser_BgCaresforpetsflg = "N";
                    cusbackgpersontraits.Matuser_BgLovingflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesartflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesnatureflg = "N";
                    cusbackgpersontraits.Matuser_BgFamilyorientedflg = "N";
                    cusbackgpersontraits.Matuser_BgHealthconsciousflg = "N";
                    cusbackgpersontraits.Matuser_BgTeetotallerflg = "N";
                    cusbackgpersontraits.Matuser_BgCaresforpetsflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesreadingflg = "N";
                    cusbackgpersontraits.Matuser_BgLikesliteratureflg = "N";
                    cusbackgpersontraits.Matuser_CreateTS = DateTime.Now;
                    cusbackgpersontraits.Matuser_UpdateTS = DateTime.Now;
                    db.Matuser_BackgroundPersonalityInterests.Add(cusbackgpersontraits);

                    var religionid = (from q in db.Matuser_Religion
                                      where q.Matuser_Religionname == "N/A"
                                      select new { q.Matuser_ReligionID }).SingleOrDefault();



                    cusmatusercaste.Matuser_Castename = "N/A";
                    cusmatusercaste.Matuser_ReligionID = religionid.Matuser_ReligionID;
                    cusmatusercaste.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Caste.Add(cusmatusercaste);
                    db.SaveChanges();

                    cusmatuserweight.Matuser_Profileweightinkgs = 0;
                    cusmatuserweight.Matuser_ProfileweightID = 0;
                    cusmatuserweight.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_WeightProfile.Add(cusmatuserweight);

                    var profilecasteid = (from q in db.Matuser_Caste

                                          where q.MatUser_ProfileIDGN == cusmatusercaste.MatUser_ProfileIDGN
                                          select new { q.Matuser_ProfileCasteID }).SingleOrDefault();

                    cusmatuserreligionprofile.Matuser_ProfileCasteID = profilecasteid.Matuser_ProfileCasteID;
                    cusmatuserreligionprofile.Matuser_GothraName = "N/A";
                    cusmatuserreligionprofile.Matuser_SubcasteName = "N/A";
                    cusmatuserreligionprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;

                    db.Matuser_ReligionProfile.Add(cusmatuserreligionprofile);
                    db.SaveChanges();



                    var ProfileRelCastSubcastID = (from q in db.Matuser_ReligionProfile
                                                   where q.MatUser_ProfileIDGN == cusmatuserreligionprofile.MatUser_ProfileIDGN
                                                   //where q.Matuser_GothraName == cusmatuserreligionprofile.Matuser_GothraName
                                                   //where q.Matuser_SubcasteName == cusmatuserreligionprofile.Matuser_SubcasteName
                                                   select new { q.MatUser_ProfileRelCastSubcastID }).SingleOrDefault();



                    var profilelanguadeid = (from q in db.Matuser_UserLanguage
                                             where q.Matuser_MotherTongueLanguage == "N/A"
                                             select new { q.Matuser_MotherTongueID }).SingleOrDefault();

                    var profilemarstatid = (from q in db.Matuser_Maritalstatus
                                            where q.Matuser_MaritalStatusdesc == "N/A"
                                            select new { q.MatUser_MaritalStatusID }).SingleOrDefault();


                    var profilephystat = (from q in db.Matuser_PhysicalStatus
                                          where q.Matuser_Profilephysicalstatusdesc == "N/A"
                                          select new { q.Matuser_ProfilephysicalstatusID }).SingleOrDefault();

                    var profilecomplex = (from q in db.Matuser_ComplexionProfile
                                          where q.Matuser_Profilecomplexionname == "N/A"
                                          select new { q.Matuser_ProfilecomplexionID }).SingleOrDefault();

                    var profileheight = (from q in db.Matuser_HeightProfile
                                         where q.Matuser_Profileheightincms == 0
                                         where q.Matuser_Profileheightinftinches == "0"
                                         select new { q.Matuser_ProfileheightID }).SingleOrDefault();

                    var profilewightid = (from q in db.Matuser_WeightProfile
                                          where q.MatUser_ProfileIDGN == cusmatuserweight.MatUser_ProfileIDGN
                                          //where q.Matuser_Profileweightinlbs == 0
                                          select new { q.Matuser_ProfileweightID }).SingleOrDefault();

                    var profileagerange = (from q in db.Matuser_AgeRange
                                           where q.Matuser_Loweragelimit == 18
                                           select new { q.Matuser_AgeRangeID }).SingleOrDefault();


                    cusmatuserphysicalprofile.Matuser_AgeRangeID = profileagerange.Matuser_AgeRangeID;
                    cusmatuserphysicalprofile.Matuser_ProfilephysicalstatusID = profilephystat.Matuser_ProfilephysicalstatusID;
                    cusmatuserphysicalprofile.Matuser_ProfilecomplexionID = profilecomplex.Matuser_ProfilecomplexionID;
                    cusmatuserphysicalprofile.Matuser_ProfileheightID = profileheight.Matuser_ProfileheightID;
                    cusmatuserphysicalprofile.Matuser_ProfileweightID = profilewightid.Matuser_ProfileweightID;
                    cusmatuserphysicalprofile.Matuser_BodyTypeID = 1;
                    cusmatuserphysicalprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_PhysicalProfile.Add(cusmatuserphysicalprofile);
                    db.SaveChanges();

                    var profilephysicdetid = (from q in db.Matuser_PhysicalProfile
                                              where q.MatUser_ProfileIDGN == cusmatuserphysicalprofile.MatUser_ProfileIDGN
                                              //where q.Matuser_ProfilecomplexionID == profilecomplex.Matuser_ProfilecomplexionID
                                              //where q.Matuser_ProfileheightID == profileheight.Matuser_ProfileheightID
                                              //where q.Matuser_ProfileweightID == profilewightid.Matuser_ProfileweightID
                                              select new { q.Matuser_PhysicalProfileID }).SingleOrDefault();

                    var cusmatuserraasi = (from q in db.Matuser_Raasi
                                           where q.Matuser_ProfileRaasiName == "N/A"
                                           select new { q.Matuser_ProfileRaasiID }).SingleOrDefault();

                    var cusmatuserstar = (from q in db.Matuser_Star
                                          where q.Matuser_ProfileStarName == "N/A"
                                          select new { q.Matuser_ProfileStarID }).SingleOrDefault();

                    cusmatuserastprofile.Matuser_ProfileRaasiID = cusmatuserraasi.Matuser_ProfileRaasiID;
                    cusmatuserastprofile.Matuser_ProfileStarID = cusmatuserstar.Matuser_ProfileStarID;
                    cusmatuserastprofile.Matuser_Kujadoshamflag = "N";
                    cusmatuserastprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Astrologicalprofile.Add(cusmatuserastprofile);
                    db.SaveChanges();

                    cusmatuserempprofile.EmployerName = "N/A";
                    cusmatuserempprofile.Matuser_SalaryinLakhrupees = 0;
                    cusmatuserempprofile.Matuser_Employmentdetails = "N/A";
                    cusmatuserempprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Employmentprofile.Add(cusmatuserempprofile);
                    db.SaveChanges();

                    var cusprofileastroid = (from q in db.Matuser_Astrologicalprofile
                                             where q.MatUser_ProfileIDGN == cusmatuserastprofile.MatUser_ProfileIDGN
                                             //where q.Matuser_ProfileRaasiID == cusmatuserraasi.Matuser_ProfileRaasiID
                                             select new { q.Matuser_ProfileAstrologicalID }).SingleOrDefault();

                    var cusmatusereduid = (from q in db.Matuser_Educationalprofile
                                           where q.Matuser_highestqualification == "N/A"
                                           select new { q.MatUser_EducationalID }).SingleOrDefault();

                    var cusmatuserempid = (from q in db.Matuser_Employmentprofile
                                           where q.MatUser_ProfileIDGN == cusmatuserempprofile.MatUser_ProfileIDGN
                                           select new { q.Matuser_EmploymentID }).SingleOrDefault();

                    cusmatuseroccprofile.Matuser_EducationalID = cusmatusereduid.MatUser_EducationalID;
                    cusmatuseroccprofile.Matuser_EmploymentID = cusmatuserempid.Matuser_EmploymentID;
                    cusmatuseroccprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_Occupationalprofile.Add(cusmatuseroccprofile);
                    db.SaveChanges();

                    var profileoccupationid = (from q in db.Matuser_Occupationalprofile
                                               where q.MatUser_ProfileIDGN == cusmatuseroccprofile.MatUser_ProfileIDGN
                                               //where q.Matuser_EmploymentID == cusmatuserempid.Matuser_EmploymentID
                                               select new { q.MatUser_OccupationalID }).SingleOrDefault();

                    var drinkingstatus = (from q in db.Matuser_DrinkingStatus
                                          where q.Matuser_DrinkingStatusdesc == "N/A"
                                          select new { q.Matuser_DrinkingID }).SingleOrDefault();

                    var smokingstatus = (from q in db.Matuser_SmokingStatus
                                         where q.Matuser_SmokingStatusdesc == "N/A"
                                         select new { q.Matuser_SmokingID }).SingleOrDefault();

                    var eatingstatus = (from q in db.Matuser_EatingStatus
                                        where q.Matuser_EatingStatusdesc == "N/A"
                                        select new { q.Matuser_EatingID }).SingleOrDefault();

                    cusmatuserhabitprofile.Matuser_DrinkingID = drinkingstatus.Matuser_DrinkingID;
                    cusmatuserhabitprofile.Matuser_SmokingID = smokingstatus.Matuser_SmokingID;
                    cusmatuserhabitprofile.Matuser_EatingID = eatingstatus.Matuser_EatingID;
                    cusmatuserhabitprofile.Create_ts = System.DateTime.Now;
                    cusmatuserhabitprofile.Update_ts = System.DateTime.Now;
                    cusmatuserhabitprofile.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_HabitProfile.Add(cusmatuserhabitprofile);
                    db.SaveChanges();

                    var profilehabitid = (from q in db.Matuser_HabitProfile
                                          where q.MatUser_ProfileIDGN == cusmatuserhabitprofile.MatUser_ProfileIDGN
                                          //where q.Matuser_EatingID == eatingstatus.Matuser_EatingID
                                          //where q.Matuser_SmokingID == smokingstatus.Matuser_SmokingID
                                          select new { q.MatUser_HabitualID }).SingleOrDefault();


                    var familyvalu = (from q in db.MatuserFamily_Values
                                      where q.Matuser_Familyvalues == "N/A"
                                      select new { q.Matuser_FamilyValuesID }).SingleOrDefault();
                    var famliytyp = (from q in db.MatuserFamily_Type
                                     where q.Matuser_FamilyType == "N/A"
                                     select new { q.Matuser_FamilyTypeID }).SingleOrDefault();
                    var familystat = (from q in db.MatuserFamily_Status
                                      where q.Matuser_FamilyStatus == "N/A"
                                      select new { q.Matuser_FamilyStatusID }).SingleOrDefault();

                    cusmatuserfamilyprof.Matuser_FamilyStatusID = familystat.Matuser_FamilyStatusID;
                    cusmatuserfamilyprof.Matuser_FamilyValuesID = familyvalu.Matuser_FamilyValuesID;
                    cusmatuserfamilyprof.Matuser_FamilyTypeID = famliytyp.Matuser_FamilyTypeID;
                    cusmatuserfamilyprof.Matuser_FatherstatusID = 4;
                    cusmatuserfamilyprof.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    db.Matuser_FamilyProfile.Add(cusmatuserfamilyprof);
                    db.SaveChanges();

                    var profilefamlydetid = (from q in db.Matuser_FamilyProfile
                                             where q.MatUser_ProfileIDGN == cusmatuserfamilyprof.MatUser_ProfileIDGN
                                             //where q.Matuser_FamilyValuesID == familyvalu.Matuser_FamilyValuesID
                                             //where q.Matuser_FamilyTypeID == famliytyp.Matuer_FamilyTypeID
                                             select new { q.MatUser_FamilydetID }).SingleOrDefault();


                    cusmatuserplan.Matuser_Planname = "N/A";
                    cusmatuserplan.Matuser_Planperioddays = 0;
                    cusmatuserplan.Matuser_PriceinUSD = 0;
                    cusmatuserplan.Matuser_PriceinINR = 0;
                    cusmatuserplan.Matuser_Planstartdate = System.DateTime.Now;
                    cusmatuserplan.Matuser_Planenddate = System.DateTime.Now;
                    cusmatuserplan.Matuser_activeflag = "N";
                    cusmatuserplan.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    cusmatuserplan.Create_ts = System.DateTime.Now;
                    cusmatuserplan.Update_ts = System.DateTime.Now;

                    db.Matuser_Plan.Add(cusmatuserplan);
                    db.SaveChanges();

                    var profileplan = (from q in db.Matuser_Plan
                                           //where q.Matuser_Planname == "N/A"
                                           //where q.Matuser_Planperioddays == 0
                                           //where q.Matuser_PriceinINR == 0
                                           //where q.Matuser_PriceinUSD == 0
                                       where q.MatUser_ProfileIDGN == cusmatuserplan.MatUser_ProfileIDGN

                                       select new { q.Matuser_PlanID }).SingleOrDefault();


                    cusmatuserphoto.Matuser_Phototititle = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL1 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL2 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL3 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL4 = "N/A";
                    cusmatuserphoto.Matuser_PhotoURL5 = "N/A";
                    cusmatuserphoto.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    cusmatuserphoto.Create_ts = System.DateTime.Now;
                    cusmatuserphoto.Update_ts = System.DateTime.Now;

                    db.Matuser_Photo.Add(cusmatuserphoto);
                    db.SaveChanges();

                    var profilephoto = (from q in db.Matuser_Photo
                                            //where q.Matuser_Phototititle == "N/A"
                                            //where q.Matuser_PhotoURL1 == "N/A"
                                            //where q.Matuser_PhotoURL3 == "N/A"
                                            //where q.Matuser_PhotoURL2 == "N/A"
                                            //where q.Matuser_PhotoURL4 == "N/A"
                                            //where q.Matuser_PhotoURL5 == "N/A"
                                        where q.MatUser_ProfileIDGN == cusmatuserphoto.MatUser_ProfileIDGN
                                        select new { q.Matuser_PhotoID }).SingleOrDefault();

                    var cusresidentstat = (from q in db.Matuser_ResidentStatus
                                           where q.Matuser_Residentstatusdesc == "N/A"
                                           select new { q.Matuser_ResidentstatusID }).SingleOrDefault();


                    int cuslogid = loginid.MatUser_LoginID;
                    custregister.MatUser_LoginID = cuslogid;
                    custregister.MatUser_ProfileIDGN = "VV" + currprofileid + "HK" + Randomnumber;
                    custregister.MatUser_ProfileForID = matuserprofileid.MatUser_ProfileForID;
                    custregister.MatUser_ProfileaddressID = Convert.ToInt32(matuseraddressid.MatUser_ProfileaddressID);
                    custregister.MatUser_FirstName = bsd.MatUser_FirstName;
                    custregister.MatUser_LastName = bsd.MatUser_LastName;
                    custregister.MatUser_DOB = bsd.MatUser_DOB;
                    custregister.MatUser_Gender = bsd.MatUser_Gender;
                    custregister.MatUser_ProfileRelCastSubcastID = ProfileRelCastSubcastID.MatUser_ProfileRelCastSubcastID;
                    custregister.MatUser_MotherTongueID = profilelanguadeid.Matuser_MotherTongueID;
                    custregister.MatUser_MaritalStatusID = profilemarstatid.MatUser_MaritalStatusID;
                    custregister.MatUser_PhysicaldetID = profilephysicdetid.Matuser_PhysicalProfileID;
                    custregister.MatUser_AstrologicalID = cusprofileastroid.Matuser_ProfileAstrologicalID;
                    custregister.MatUser_OccupationalID = profileoccupationid.MatUser_OccupationalID;
                    custregister.MatUser_HabitualID = profilehabitid.MatUser_HabitualID;
                    custregister.MatUser_FamilydetID = profilefamlydetid.MatUser_FamilydetID;
                    custregister.MatUser_PlanID = profileplan.Matuser_PlanID;
                    custregister.Matuser_PhotoID = profilephoto.Matuser_PhotoID;
                    custregister.Matuser_ResidentstatusID = cusresidentstat.Matuser_ResidentstatusID;
                    custregister.Matuser_BgPerIntID = cusbackgpersontraits.Matuser_BgPerIntID;
                    custregister.Comments = string.Empty;
                    custregister.Create_ts = DateTime.Now;
                    custregister.Update_ts = DateTime.Now;
                    db.Matuser_Profile.Add(custregister);
                    db.SaveChanges();
                    DbTrans.Commit();

                    var password = (from q in db.Matuser_Login
                                    where q.Matuser_ProfileloginID == bsd.EmailTaggedToAddress
                                    select new { q.Matuser_ProfileloginID, q.Matuser_ProfilePassword }).ToList();

                    return Ok(password);
                }
                else
                {
                    List<basicSearch> flg = new List<basicSearch>();
                    flg.Add(new basicSearch { ErrormsgOrflg = "N" });

                    return Ok(flg);
                }
            }

            catch (Exception ex)
            {
                DbTrans.Rollback();
                return Ok();
                throw ex;
            }

        }

        [Route("api/Search/Getreceivedmessages")]
        public IHttpActionResult Getreceivedmessages(string customerid)
        {

            var receusrdisgrp = (from q in db.Matuser_MessageReceiver
                                 join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                 join s in db.Matuser_Profile on q.Matuser_SenderProfileID equals s.MatUser_ProfileIDGN
                                 where q.Matuser_ReceiverProfileID == customerid
                                 where q.Matuser_Messagetypeid == 2
                                 where q.Matuser_Firsttimeflag == "N"
                                 select new
                                 {
                                     username = (s.MatUser_FirstName + s.MatUser_LastName),
                                     sendusrid = q.Matuser_SenderProfileID,
                                     sendusruniqueid = q.Matuser_MessageReceiverID,
                                     sendusridh = "#" + (q.Matuser_MessageReceiverID) + (q.Matuser_SenderProfileID).Substring(0, 4),
                                     sendrid = (q.Matuser_MessageReceiverID) + (q.Matuser_SenderProfileID).Substring(0, 4),
                                     recevdtime = q.Matuser_Receivedts,
                                     message = q.Matuser_Message,
                                     displaytext = q.Matuser_Receivedts + "    " + q.Matuser_Message,
                                     messgdisplytext = (q.Matuser_Message).Substring(0, 30),
                                 }).OrderByDescending(x => x.recevdtime).ThenBy(x => x.username).ToList().Distinct();

            return Ok(receusrdisgrp);
        }
        [Route("api/Search/Getsentmessages")]
        public IHttpActionResult Getsentmessages(string customerid)
        {

            var receusrdisgrp = (from q in db.Matuser_Messagesender
                                 join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                 join s in db.Matuser_Profile on q.Matuser_ReceiverProfileID equals s.MatUser_ProfileIDGN
                                 where q.Matuser_SenderProfileID == customerid
                                 where q.Matuser_Messagetypeid == 1
                                 where q.Matuser_Firsttimeflag == "N"
                                 select new
                                 {
                                     username = (s.MatUser_FirstName + s.MatUser_LastName),
                                     sendusrid = q.Matuser_ReceiverProfileID,
                                     sendusruniqueid = q.Matuser_MessageSenderID,
                                     sentts = q.Matuser_sentts,
                                     message = q.Matuser_Message,
                                 }).OrderByDescending(x => x.sentts).ThenBy(x => x.username).ToList().Distinct();
            return Ok(receusrdisgrp);
        }

        [Route("api/Search/Archivedsentmessages")]
        public IHttpActionResult Archivedsentmessages(string customerid)
        {
            var sendusrarcvdgrp = (from q in db.Matuser_Messagesender
                                   join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                   join s in db.Matuser_Profile on q.Matuser_SenderProfileID equals s.MatUser_ProfileIDGN
                                   where q.Matuser_SenderProfileID == customerid
                                   where q.Matuser_Messagetypeid == 4
                                   where q.Matuser_Firsttimeflag == "N"
                                   select new
                                   {
                                       username = (s.MatUser_FirstName + s.MatUser_LastName),
                                       sendusrid = q.Matuser_SenderProfileID,
                                       sendusruniqueid = q.Matuser_MessageSenderID,
                                       sendtime = q.Matuser_sentts,
                                       message = q.Matuser_Message,
                                   }).OrderByDescending(x => x.sendtime).ThenBy(x => x.username).ToList().Distinct();
            return Ok(sendusrarcvdgrp);
        }

        [Route("api/Search/Archivedreceivdmessages")]
        public IHttpActionResult Archivedreceivdmessages(string customerid)
        {
            var receusrdisgrp = (from q in db.Matuser_MessageReceiver
                                 join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                 join s in db.Matuser_Profile on q.Matuser_SenderProfileID equals s.MatUser_ProfileIDGN
                                 where q.Matuser_ReceiverProfileID == customerid
                                 where q.Matuser_Messagetypeid == 6
                                 where q.Matuser_Firsttimeflag == "N"
                                 select new
                                 {
                                     username = (s.MatUser_FirstName + s.MatUser_LastName),
                                     sendusrid = q.Matuser_SenderProfileID,
                                     sendusruniqueid = q.Matuser_MessageReceiverID,
                                     recevdtime = q.Matuser_Receivedts,
                                     message = q.Matuser_Message,
                                 }).OrderByDescending(x => x.recevdtime).ThenBy(x => x.username).ToList().Distinct();
            return Ok(receusrdisgrp);
        }

        [Route("api/Search/interestedmessages")]
        public IHttpActionResult interestedmessages(string customerid)
        {
            var Intrestedprofiles = (from q in db.Matuser_MessageReceiver
                                     join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                     join s in db.Matuser_Profile on q.Matuser_SenderProfileID equals s.MatUser_ProfileIDGN
                                     where q.Matuser_ReceiverProfileID == customerid
                                     where q.Matuser_Messagetypeid == 5
                                     where q.Matuser_ReqacceptancestatusID == 1
                                     where q.Matuser_Firsttimeflag == "Y"
                                     select new
                                     {
                                         username = (s.MatUser_FirstName + s.MatUser_LastName),
                                         recevdtime = q.Matuser_Receivedts,
                                         messgdisplytext = (q.Matuser_Message).Substring(0, 30),
                                         message = q.Matuser_Message,
                                         sendusrid = q.Matuser_SenderProfileID,
                                         sendusruniqueid = q.Matuser_MessageReceiverID,
                                         sendusridhash = "#" + q.Matuser_SenderProfileID
                                     }).ToList();

            return Ok(Intrestedprofiles);
        }


        [Route("api/Search/GetProfileDetails")]
        public IHttpActionResult GetProfileDetails(string loginid)
        {
            try
            {
                var profile = (from q in db.Matuser_Profile
                               join p in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals p.MatUser_ProfileRelCastSubcastID
                               join r in db.Matuser_Caste on p.Matuser_ProfileCasteID equals r.Matuser_ProfileCasteID
                               join t in db.Matuser_Astrologicalprofile on q.MatUser_AstrologicalID equals t.Matuser_ProfileAstrologicalID
                               join u in db.Matuser_Religion on r.Matuser_ReligionID equals u.Matuser_ReligionID
                               join w in db.Matuser_Maritalstatus on q.MatUser_MaritalStatusID equals w.MatUser_MaritalStatusID
                               join x in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals x.Matuser_MotherTongueID
                               join z in db.Matuser_Address on q.MatUser_ProfileaddressID equals z.MatUser_ProfileaddressID
                               join a in db.Matuser_Cntrycode on z.CntID equals a.CntID
                               join b in db.Matuser_Country on a.CountryID equals b.CountryID
                               join d in db.Matuser_Occupationalprofile on q.MatUser_OccupationalID equals d.MatUser_OccupationalID
                               join f in db.Matuser_Educationalprofile on d.Matuser_EducationalID equals f.MatUser_EducationalID
                               join g in db.Matuser_Star on t.Matuser_ProfileStarID equals g.Matuser_ProfileStarID
                               join h in db.Matuser_HabitProfile on q.MatUser_HabitualID equals h.MatUser_HabitualID
                               join i in db.Matuser_EatingStatus on h.Matuser_EatingID equals i.Matuser_EatingID
                               join j in db.Matuser_DrinkingStatus on h.Matuser_DrinkingID equals j.Matuser_DrinkingID
                               join k in db.Matuser_SmokingStatus on h.Matuser_SmokingID equals k.Matuser_SmokingID
                               join l in db.Matuser_Login on q.MatUser_LoginID equals l.MatUser_LoginID
                               join m in db.Matuser_Employmentprofile on d.Matuser_EmploymentID equals m.Matuser_EmploymentID
                               join ac in db.Matuser_Maritalstatus on q.MatUser_MaritalStatusID equals ac.MatUser_MaritalStatusID
                               join aj in db.Matuser_Photo on q.Matuser_PhotoID equals aj.Matuser_PhotoID

                               join s in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals s.Matuser_PhysicalProfileID
                               join v in db.Matuser_HeightProfile on s.Matuser_ProfileheightID equals v.Matuser_ProfileheightID
                               join y in db.Matuser_PhysicalStatus on s.Matuser_ProfilephysicalstatusID equals y.Matuser_ProfilephysicalstatusID
                               join c in db.Matuser_ResidentStatus on q.Matuser_ResidentstatusID equals c.Matuser_ResidentstatusID
                               join ab in db.Matuser_WeightProfile on s.Matuser_ProfileweightID equals ab.Matuser_ProfileweightID
                               join ae in db.Matuser_BodyType on s.Matuser_BodyTypeID equals ae.Matuser_BodyTypeID
                               join af in db.Matuser_ComplexionProfile on s.Matuser_ProfilecomplexionID equals af.Matuser_ProfilecomplexionID

                               join n in db.Matuser_FamilyProfile on q.MatUser_FamilydetID equals n.MatUser_FamilydetID
                               join o in db.MatuserFamily_Type on n.Matuser_FamilyTypeID equals o.Matuser_FamilyTypeID
                               join ag in db.MatuserFamily_Values on n.Matuser_FamilyValuesID equals ag.Matuser_FamilyValuesID
                               join ah in db.MatuserFamily_Status on n.Matuser_FamilyStatusID equals ah.Matuser_FamilyStatusID
                               join ai in db.Matuser_FatherStatus on n.Matuser_FatherstatusID equals ai.Matuser_FatherstatusID
                               join ak in db.Matuser_BackgroundPersonalityInterests on q.Matuser_BgPerIntID equals ak.Matuser_BgPerIntID

                               where l.Matuser_ProfileloginID == loginid || q.MatUser_ProfileIDGN == loginid

                               select new
                               {
                                   Matuser_PhotoURL1 = aj.Matuser_PhotoURL1,
                                   Matuser_PhotoURL2 = aj.Matuser_PhotoURL2,
                                   Matuser_PhotoURL3 = aj.Matuser_PhotoURL3,
                                   Matuser_PhotoURL4 = aj.Matuser_PhotoURL4,
                                   Matuser_PhotoURL5 = aj.Matuser_PhotoURL5,
                                   Comments = q.Comments,

                                   MatUser_EducationalID = f.MatUser_EducationalID,
                                   Matuser_highestqualification = f.Matuser_highestqualification,

                                   Matuser_Employmentdetails = m.Matuser_Employmentdetails,
                                   MatUser_OccupationalID = d.MatUser_OccupationalID,
                                   EmployerName = m.EmployerName,
                                   Matuer_SalaryinLakhrupees = m.Matuser_SalaryinLakhrupees,
                                   MatUser_FirstName = q.MatUser_FirstName,
                                   MatUser_LastName = q.MatUser_LastName,
                                   MatUser_DOB = q.MatUser_DOB,

                                   Matuser_ProfileheightID = v.Matuser_ProfileheightID,
                                   Matuser_Profileheightinftinches = v.Matuser_Profileheightinftinches,

                                   Matuser_Profileweightinkgs = ab.Matuser_Profileweightinkgs,

                                   Matuser_MotherTongueID = x.Matuser_MotherTongueID,
                                   Matuser_MotherTongueLanguage = x.Matuser_MotherTongueLanguage,

                                   MatUser_MaritalStatusID = w.MatUser_MaritalStatusID,
                                   Matuser_MaritalStatusdesc = w.Matuser_MaritalStatusdesc,

                                   Matuser_BodyTypeID = ae.Matuser_BodyTypeID,
                                   Matuser_BodyType1 = ae.Matuser_BodyTypeDesc,

                                   Matuser_ProfilecomplexionID = af.Matuser_ProfilecomplexionID,
                                   Matuser_Profilecomplexionname = af.Matuser_Profilecomplexionname,

                                   Matuser_ProfilephysicalstatusID = y.Matuser_ProfilephysicalstatusID,
                                   Matuser_Profilephysicalstatusdesc = y.Matuser_Profilephysicalstatusdesc,

                                   Matuser_EatingID = i.Matuser_EatingID,
                                   Matuser_EatingStatusdesc = i.Matuser_EatingStatusdesc,

                                   Matuser_DrinkingID = j.Matuser_DrinkingID,
                                   Matuser_DrinkingStatusdesc = j.Matuser_DrinkingStatusdesc,

                                   Matuser_SmokingID = k.Matuser_SmokingID,
                                   Matuser_SmokingStatusdesc = k.Matuser_SmokingStatusdesc,

                                   PhoneNumberTaggedToAddress = z.PhoneNumberTaggedToAddress,
                                   EmailTaggedToAddress = z.EmailTaggedToAddress,

                                   Matuser_ResidentstatusID = c.Matuser_ResidentstatusID,
                                   Matuser_Residentstatusdesc = c.Matuser_Residentstatusdesc,

                                   CountryID = b.CountryID,
                                   CountryName = b.CountryName,

                                   State = z.State,
                                   CityName = z.CityName,

                                   Matuser_ReligionID = u.Matuser_ReligionID,
                                   Matuser_Religionname = u.Matuser_Religionname,

                                   Matuser_ProfileCasteID = r.Matuser_ProfileCasteID,
                                   Matuser_Castename = r.Matuser_Castename,

                                   MatUser_ProfileRelCastSubcastID = p.MatUser_ProfileRelCastSubcastID,
                                   Matuser_SubcasteName = p.Matuser_SubcasteName,
                                   Matuser_GothraName = p.Matuser_GothraName,

                                   Matuser_ProfileStarID = g.Matuser_ProfileStarID,
                                   Matuser_ProfileStarName = g.Matuser_ProfileStarName,

                                   Matuser_Kujadoshamflag = t.Matuser_Kujadoshamflag,

                                   Matuser_FamilyTypeID = o.Matuser_FamilyTypeID,
                                   Matuser_FamilyType = o.Matuser_FamilyType,

                                   Matuser_FamilyValuesID = ag.Matuser_FamilyValuesID,
                                   Matuser_Familyvalues = ag.Matuser_Familyvalues,

                                   Matuser_FamilyStatusID = ah.Matuser_FamilyStatusID,
                                   Matuser_FamilyStatus = ah.Matuser_FamilyStatus,

                                   Matuser_FatherstatusID = ai.Matuser_FatherstatusID,
                                   Matuser_Fatherstatusdesc = ai.Matuser_Fatherstatusdesc,

                                   Affluent = ak.Matuser_BgAffluentflg,
                                   Attract = ak.Matuser_BgAttractiveflg,
                                   Cares = ak.Matuser_BgCaresforpetsflg,
                                   Cheerful = ak.Matuser_BgCheerfulflg,
                                   Enjoyfod = ak.Matuser_BgEnjoysfoodflg,
                                   Enjoysmusic = ak.Matuser_BgEnjoysmusicflg,
                                   Familyori = ak.Matuser_BgFamilyorientedflg,
                                   Health = ak.Matuser_BgHealthconsciousflg,
                                   Likart = ak.Matuser_BgLikesartflg,
                                   litera = ak.Matuser_BgLikesliteratureflg,
                                   Likenat = ak.Matuser_BgLikesnatureflg,
                                   Likesphoto = ak.Matuser_BgLikesphotographyflg,
                                   reading = ak.Matuser_BgLikesreadingflg,
                                   Loving = ak.Matuser_BgLovingflg,
                                   Spiritual = ak.Matuser_BgSpirituallyinclinedflg,
                                   Teet = ak.Matuser_BgTeetotallerflg,
                                   WarmFrnd = ak.Matuser_BgWarmFriendlyflg,
                                   Welledu = ak.Matuser_BgWelleducatedflg,

                               }).ToList();


                return Ok(profile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Edit Operation
        //http://localhost:49681/api/Search/PostEditProfile?bsd = bsd
        [Route("api/Search/PostEditProfile")]
        [HttpPost]
        public IHttpActionResult PostEditProfile(basicSearch bsd)
        {
            var DbTrans = db.Database.BeginTransaction();
            try
            {
                var updateProfile = (from q in db.Matuser_Profile
                                     join s in db.Matuser_Login on q.MatUser_LoginID equals s.MatUser_LoginID
                                     where s.Matuser_ProfileloginID == bsd.Matuser_ProfileloginID
                                     join p in db.Matuser_Occupationalprofile on q.MatUser_OccupationalID equals p.MatUser_OccupationalID
                                     join r in db.Matuser_Employmentprofile on p.Matuser_EmploymentID equals r.Matuser_EmploymentID
                                     join t in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals t.Matuser_PhysicalProfileID
                                     join u in db.Matuser_HeightProfile on t.Matuser_ProfileheightID equals u.Matuser_ProfileheightID
                                     join v in db.Matuser_WeightProfile on t.Matuser_ProfileweightID equals v.Matuser_ProfileweightID
                                     join w in db.Matuser_UserLanguage on q.MatUser_MotherTongueID equals w.Matuser_MotherTongueID
                                     join x in db.Matuser_HabitProfile on q.MatUser_HabitualID equals x.MatUser_HabitualID
                                     join y in db.Matuser_Address on q.MatUser_ProfileaddressID equals y.MatUser_ProfileaddressID
                                     join z in db.Matuser_Cntrycode on y.CntID equals z.CntID
                                     join a in db.Matuser_Country on z.CountryID equals a.CountryID
                                     join b in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals b.MatUser_ProfileRelCastSubcastID
                                     join c in db.Matuser_Caste on b.Matuser_ProfileCasteID equals c.Matuser_ProfileCasteID
                                     join d in db.Matuser_Astrologicalprofile on q.MatUser_AstrologicalID equals d.Matuser_ProfileAstrologicalID
                                     join f in db.Matuser_FamilyProfile on q.MatUser_FamilydetID equals f.MatUser_FamilydetID
                                     join g in db.Matuser_Photo on q.Matuser_PhotoID equals g.Matuser_PhotoID
                                     join h in db.Matuser_BackgroundPersonalityInterests on q.Matuser_BgPerIntID equals h.Matuser_BgPerIntID

                                     select new { q, r, p, u, t, v, w, x, y, z, b, c, d, f, g, h }).SingleOrDefault();

                updateProfile.g.Matuser_Phototititle = bsd.MatUser_FirstName;
                if (bsd.Matuser_PhotoURL1 != null)
                {
                    updateProfile.g.Matuser_PhotoURL1 = bsd.Matuser_PhotoURL1;
                }

                if (bsd.Matuser_PhotoURL2 != null)
                {
                    updateProfile.g.Matuser_PhotoURL2 = bsd.Matuser_PhotoURL2;
                }

                if (bsd.Matuser_PhotoURL3 != null)
                {
                    updateProfile.g.Matuser_PhotoURL3 = bsd.Matuser_PhotoURL3;
                }

                if (bsd.Matuser_PhotoURL4 != null)
                {
                    updateProfile.g.Matuser_PhotoURL4 = bsd.Matuser_PhotoURL4;
                }

                if (bsd.Matuser_PhotoURL5 != null)
                {
                    updateProfile.g.Matuser_PhotoURL5 = bsd.Matuser_PhotoURL5;
                }


                //about me
                updateProfile.q.Comments = bsd.Comments;
                updateProfile.p.Matuser_EducationalID = bsd.Matuser_EducationalID;
                updateProfile.r.Matuser_Employmentdetails = bsd.Matuser_Employmentdetails;
                updateProfile.r.Matuser_SalaryinLakhrupees = bsd.Matuser_SalaryinLakhrupees;
                updateProfile.r.EmployerName = bsd.EmployerName;

                // Basic details
                updateProfile.q.MatUser_FirstName = bsd.MatUser_FirstName;
                updateProfile.q.MatUser_LastName = bsd.MatUser_LastName;
                updateProfile.q.MatUser_DOB = bsd.MatUser_DOB;
                updateProfile.t.Matuser_ProfileheightID = bsd.Matuser_ProfileheightID;
                updateProfile.v.Matuser_Profileweightinkgs = bsd.Matuser_Profileweightinkgs;
                updateProfile.v.Matuser_Profileweightinlbs = bsd.Matuser_Profileweightinlbs;
                updateProfile.q.MatUser_MotherTongueID = bsd.MatUser_MotherTongueID;
                updateProfile.q.MatUser_MaritalStatusID = bsd.MatUser_MaritalStatusID;
                updateProfile.t.Matuser_BodyTypeID = bsd.Matuser_BodyTypeID;
                updateProfile.t.Matuser_ProfilecomplexionID = bsd.Matuser_ProfilecomplexionID;
                updateProfile.t.Matuser_ProfilephysicalstatusID = bsd.Matuser_ProfilephysicalstatusID;
                updateProfile.x.Matuser_EatingID = bsd.Matuser_EatingID;
                updateProfile.x.Matuser_DrinkingID = bsd.Matuser_DrinkingID;
                updateProfile.x.Matuser_SmokingID = bsd.Matuser_SmokingID;

                //Contact Details
                updateProfile.q.Matuser_ResidentstatusID = bsd.Matuser_ResidentstatusID;
                updateProfile.y.PhoneNumberTaggedToAddress = bsd.PhoneNumberTaggedToAddress;
                updateProfile.y.CntID = updateProfile.z.CntID;
                updateProfile.z.CountryID = bsd.CountryID;
                updateProfile.y.State = bsd.State;
                updateProfile.y.CityName = bsd.CityName;
                updateProfile.y.EmailTaggedToAddress = bsd.EmailTaggedToAddress;

                //Religious Information

                updateProfile.q.MatUser_ProfileRelCastSubcastID = updateProfile.b.MatUser_ProfileRelCastSubcastID;
                updateProfile.c.Matuser_ReligionID = bsd.Matuser_ReligionID;
                updateProfile.b.Matuser_GothraName = bsd.Matuser_GothraName;
                updateProfile.b.Matuser_ProfileCasteID = bsd.Matuser_ProfileCasteID;
                updateProfile.d.Matuser_ProfileStarID = bsd.Matuser_ProfileStarID;
                updateProfile.b.Matuser_SubcasteName = bsd.Matuser_SubcasteName;
                updateProfile.d.Matuser_Kujadoshamflag = bsd.Matuser_Kujadoshamflag;

                //Family Details
                updateProfile.f.Matuser_FamilyValuesID = bsd.Matuser_FamilyValuesID;
                updateProfile.f.Matuser_FamilyTypeID = bsd.Matuser_FamilyTypeID;
                updateProfile.f.Matuser_FamilyStatusID = bsd.Matuser_FamilyStatusID;
                updateProfile.f.Matuser_FatherstatusID = bsd.Matuser_FatherstatusID;

                //Background Personality Interests
                updateProfile.h.Matuser_BgAffluentflg = bsd.Affluent;
                updateProfile.h.Matuser_BgAttractiveflg = bsd.Attract;
                updateProfile.h.Matuser_BgCaresforpetsflg = bsd.Cares;
                updateProfile.h.Matuser_BgCheerfulflg = bsd.Cheerful;
                updateProfile.h.Matuser_BgEnjoysfoodflg = bsd.Enjoyfod;
                updateProfile.h.Matuser_BgEnjoysmusicflg = bsd.Enjoysmusic;
                updateProfile.h.Matuser_BgFamilyorientedflg = bsd.Familyori;
                updateProfile.h.Matuser_BgHealthconsciousflg = bsd.Health;
                updateProfile.h.Matuser_BgLikesartflg = bsd.Likart;
                updateProfile.h.Matuser_BgLikesliteratureflg = bsd.litera;
                updateProfile.h.Matuser_BgLikesnatureflg = bsd.Likenat;
                updateProfile.h.Matuser_BgLikesphotographyflg = bsd.Likesphoto;
                updateProfile.h.Matuser_BgLikesreadingflg = bsd.reading;
                updateProfile.h.Matuser_BgLovingflg = bsd.Loving;
                updateProfile.h.Matuser_BgSpirituallyinclinedflg = bsd.Spiritual;
                updateProfile.h.Matuser_BgTeetotallerflg = bsd.Teet;
                updateProfile.h.Matuser_BgWarmFriendlyflg = bsd.WarmFrnd;
                updateProfile.h.Matuser_BgWelleducatedflg = bsd.Welledu;
                updateProfile.h.Matuser_UpdateTS = DateTime.Now;

                db.SaveChanges();
                DbTrans.Commit();
                //lblerror.Text = "Saved Successfully";
                //getdata();
            }
            catch (Exception ex)
            {
                DbTrans.Rollback();
                throw ex;
            }
            return Ok();
        }

        //[ResponseType(typeof(Matruser_AdDisplayImg))]
        [Route("api/Search/GetAds")]
        public IHttpActionResult GetAds(string custpagname)
        {
            try
            {
                object x = null;
                var PageAd = x;

                if (custpagname == "Login")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "Login"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation }).ToList();
                }
                else if (custpagname == "IndexMatrimony")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "IndexMatrimony"
                              where q.Matuser_AdBannerSizeID == 5 || q.Matuser_AdBannerSizeID == 11 || q.Matuser_AdBannerSizeID == 16
                              where q.AdLocation == "LeftSideAdCarosel" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { adimageurl = q.Matuser_ImgUrl, adimageloc = q.AdLocation }).ToList();
                }
                else if (custpagname == "AdvancedSearch")
                {

                }
                else if (custpagname == "Profilelogin")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "Profilelogin"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation, Adbannersize = q.Matuser_AdBannerSizeID }).ToList();
                }
                else if (custpagname == "Registratation")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "Registratation"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation, Adbannersize = q.Matuser_AdBannerSizeID }).ToList();
                }
                else if (custpagname == "BasicSearchResult")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "BasicSearchResult"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation, Adbannersize = q.Matuser_AdBannerSizeID }).ToList();
                }
                else if (custpagname == "ViewProfile")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "ViewProfile"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation, Adbannersize = q.Matuser_AdBannerSizeID }).ToList();
                }
                else if (custpagname == "EditProfile")
                {
                    PageAd = (from q in db.Matuser_AdDisplayImg
                              where q.Matuser_DisplayPageName == "EditProfile"
                              where q.Matuser_AdBannerSizeID == 5
                              where q.AdLocation == "LeftSideAd" || q.AdLocation == "RightSideAd" || q.AdLocation == "Bottom Ad"
                              select new { AdUrl = q.Matuser_ImgUrl, Adloc = q.AdLocation, Adbannersize = q.Matuser_AdBannerSizeID }).ToList();
                }

                return Ok(PageAd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //http://localhost:49681/api/Search/GetAutomatchedprofiles?id="VV22HK58597"
        [Route("api/Search/GetAutomatchedprofiles")]
        public IHttpActionResult GetAutomatchedprofiles(string id)
        {
            var SearchMatch = (from q in db.Matuser_Profile
                               join y in db.Matuser_Address on q.MatUser_ProfileaddressID equals y.MatUser_ProfileaddressID
                               join z in db.Matuser_Cntrycode on y.CntID equals z.CntID
                               join a in db.Matuser_Country on z.CountryID equals a.CountryID
                               join b in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals b.MatUser_ProfileRelCastSubcastID
                               join c in db.Matuser_Caste on b.Matuser_ProfileCasteID equals c.Matuser_ProfileCasteID
                               join t in db.Matuser_PhysicalProfile on q.MatUser_PhysicaldetID equals t.Matuser_PhysicalProfileID
                               join u in db.Matuser_HeightProfile on t.Matuser_ProfileheightID equals u.Matuser_ProfileheightID
                               where q.MatUser_ProfileIDGN == id
                               select new { q.MatUser_Gender, q.MatUser_DOB, c.Matuser_Religion, c.Matuser_Castename, u.Matuser_Profileheightincms, a.CountryName }).SingleOrDefault();

            object x = null;
            var RetriveProfiles = x;

            if (SearchMatch.MatUser_Gender == "Male")
            {
                RetriveProfiles = (from q in db.Matuser_Profile
                                   join y in db.Matuser_Address on q.MatUser_ProfileaddressID equals y.MatUser_ProfileaddressID
                                   join b in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals b.MatUser_ProfileRelCastSubcastID
                                   join c in db.Matuser_Caste on b.Matuser_ProfileCasteID equals c.Matuser_ProfileCasteID
                                   join d in db.Matuser_Photo on q.MatUser_ProfileIDGN equals d.MatUser_ProfileIDGN
                                   where DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) <= (DbFunctions.DiffYears(SearchMatch.MatUser_DOB, DateTime.Today)) - 2 && DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) >= (DbFunctions.DiffYears(SearchMatch.MatUser_DOB, DateTime.Today)) - 5 && q.MatUser_Gender == "Female"
                                   select new { q.MatUser_ProfileIDGN, FullName = q.MatUser_FirstName + " " + q.MatUser_LastName, d.Matuser_PhotoURL1, q.MatUser_FirstName, q.MatUser_LastName, q.MatUser_Gender, Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs", y.CityName, c.Matuser_Castename }).ToList();


            }

            if (SearchMatch.MatUser_Gender == "Female")
            {
                RetriveProfiles = (from q in db.Matuser_Profile
                                   join y in db.Matuser_Address on q.MatUser_ProfileaddressID equals y.MatUser_ProfileaddressID
                                   join b in db.Matuser_ReligionProfile on q.MatUser_ProfileRelCastSubcastID equals b.MatUser_ProfileRelCastSubcastID
                                   join c in db.Matuser_Caste on b.Matuser_ProfileCasteID equals c.Matuser_ProfileCasteID
                                   join d in db.Matuser_Photo on q.MatUser_ProfileIDGN equals d.MatUser_ProfileIDGN
                                   where DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) >= ((DbFunctions.DiffYears(SearchMatch.MatUser_DOB, DateTime.Today)) + 2) && DbFunctions.DiffYears(q.MatUser_DOB, DateTime.Today) <= ((DbFunctions.DiffYears(SearchMatch.MatUser_DOB, DateTime.Today)) + 5) && q.MatUser_Gender == "Male"
                                   select new { q.MatUser_ProfileIDGN, FullName = q.MatUser_FirstName + " " + q.MatUser_LastName, d.Matuser_PhotoURL1, q.MatUser_FirstName, q.MatUser_LastName, q.MatUser_Gender, Age = (DateTime.Now.Year - q.MatUser_DOB.Year).ToString() + "Yrs", y.CityName, c.Matuser_Castename }).ToList();
            }


            return Ok(RetriveProfiles);
        }

        [Route("api/Search/SendAutomatchedprofiles")]
        public IHttpActionResult SendAutomatchedprofiles(Messagesender bsd)
        {
            try
            {
                List<Messagesender> flg = new List<Messagesender>();


                var CheckFirstmsg = (from q in db.Matuser_Messagesender
                                     where q.Matuser_SenderProfileID == bsd.Matuser_SenderProfileID && q.Matuser_ReceiverProfileID == bsd.Matuser_ReceiverProfileID
                                     where q.Matuser_Firsttimeflag == "Y"
                                     select new { }).ToList();

                if (CheckFirstmsg.Count() < 1)
                {
                    Matuser_Messagesender msgsend = new Matuser_Messagesender();
                    msgsend.Matuser_SenderProfileID = bsd.Matuser_SenderProfileID;
                    msgsend.Matuser_ReceiverProfileID = bsd.Matuser_ReceiverProfileID;
                    msgsend.Matuser_Messagetypeid = db.Matuser_Messagetype.Where(x => x.Matuser_Messagetype1 == "Sent").Select(x => x.Matuser_Messagetypeid).SingleOrDefault();
                    msgsend.Matuser_ReqacceptancestatusID = db.Matuser_MessRequestAccptStatus.Where(x => x.MessageRequestStatus == "N").Select(x => x.MessageRequestStatusID).SingleOrDefault();
                    msgsend.Matuser_ReadstatusID = db.Matuser_Messagereadstatus.Where(x => x.Matuser_Messagerequeststatus == "read").Select(x => x.Matuser_MessagereadstatusID).SingleOrDefault();
                    msgsend.Matuser_Message = "I am intrested in you!";
                    msgsend.Matuser_sentts = DateTime.Now;
                    msgsend.Matuser_Firsttimeflag = "Y";

                    db.Matuser_Messagesender.Add(msgsend);

                    Matuser_MessageReceiver msgReciv = new Matuser_MessageReceiver();
                    msgReciv.Matuser_SenderProfileID = bsd.Matuser_SenderProfileID;
                    msgReciv.Matuser_ReceiverProfileID = bsd.Matuser_ReceiverProfileID;
                    msgReciv.Matuser_Messagetypeid = db.Matuser_Messagetype.Where(x => x.Matuser_Messagetype1 == "Interested").Select(x => x.Matuser_Messagetypeid).SingleOrDefault();
                    msgReciv.Matuser_ReqacceptancestatusID = db.Matuser_MessRequestAccptStatus.Where(x => x.MessageRequestStatus == "N").Select(x => x.MessageRequestStatusID).SingleOrDefault();
                    msgReciv.Matuser_ReadstatusID = db.Matuser_Messagereadstatus.Where(x => x.Matuser_Messagerequeststatus == "not read").Select(x => x.Matuser_MessagereadstatusID).SingleOrDefault();
                    msgReciv.Matuser_Message = "I am intrested in you!";
                    msgReciv.Matuser_Receivedts = DateTime.Now;
                    msgReciv.Matuser_Firsttimeflag = "Y";

                    db.Matuser_MessageReceiver.Add(msgReciv);

                    db.SaveChanges();

                    return Ok();
                }
                else
                {
                    //flg.Add(new Messagesender { ErrormsgOrflg = "AlreadyExists" });
                    //return Ok(flg);
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return Ok(ex);
                throw ex;
            }

        }

        [Route("api/Search/Getmessagecounts")]
        public IHttpActionResult Getmessagecounts(string custid)
        {
            try
            {
                var sentcount = (from q in db.Matuser_Messagesender
                                 join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                 where q.Matuser_SenderProfileID == custid
                                 where q.Matuser_Messagetypeid == 1
                                 select new { }).Count();

                var receivedcount = (from q in db.Matuser_MessageReceiver
                                     join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                     where q.Matuser_ReceiverProfileID == custid.Trim()
                                     where q.Matuser_Messagetypeid == 2
                                     select new { }).Count();


                var archsendcount = (from q in db.Matuser_MessageReceiver
                                     join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                     where q.Matuser_ReceiverProfileID == custid
                                     where q.Matuser_Messagetypeid == 6
                                     select new { }).Count();

                var archreceidcount = (from q in db.Matuser_Messagesender
                                       join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                       where q.Matuser_SenderProfileID == custid
                                       where q.Matuser_Messagetypeid == 4
                                       select new { }).Count();

                var archcount = archsendcount + archreceidcount;

                var Intrestedprofilecount = (from q in db.Matuser_MessageReceiver
                                             join r in db.Matuser_Messagetype on q.Matuser_Messagetypeid equals r.Matuser_Messagetypeid
                                             where q.Matuser_ReceiverProfileID == custid.Trim()
                                             where q.Matuser_Messagetypeid == 5
                                             where q.Matuser_ReqacceptancestatusID == 1
                                             where q.Matuser_Firsttimeflag == "Y"
                                             select new { }).Count();

                messagecount msg = new messagecount();

                msg.Interestedcount = Intrestedprofilecount;
                msg.Archivedcount = archcount;
                msg.Receivedcount = receivedcount;
                msg.Sentcount = sentcount;

                List<messagecount> counts = new List<messagecount>();

                counts.Add(new messagecount { Archivedcount = archcount, Receivedcount = receivedcount, Sentcount = sentcount, Interestedcount = Intrestedprofilecount });

                return Ok(counts);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







        // PUT: api/Search/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMatruser_Profile(int id, Matuser_Profile matruser_Profile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != matruser_Profile.MatUser_ProfileID)
            {
                return BadRequest();
            }

            db.Entry(matruser_Profile).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Matruser_ProfileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Search
        [ResponseType(typeof(Matuser_Profile))]
        public IHttpActionResult PostMatruser_Profile(Matuser_Profile matruser_Profile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Matuser_Profile.Add(matruser_Profile);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = matruser_Profile.MatUser_ProfileID }, matruser_Profile);
        }



        // DELETE: api/Search/5
        [ResponseType(typeof(Matuser_Profile))]
        public IHttpActionResult DeleteMatruser_Profile(int id)
        {
            Matuser_Profile matruser_Profile = db.Matuser_Profile.Find(id);
            if (matruser_Profile == null)
            {
                return NotFound();
            }

            db.Matuser_Profile.Remove(matruser_Profile);
            db.SaveChanges();

            return Ok(matruser_Profile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Matruser_ProfileExists(int id)
        {
            return db.Matuser_Profile.Count(e => e.MatUser_ProfileID == id) > 0;
        }
    }
    public class Error
    {
        public string ErrormsgOrflg { get; set; }
    }

    public class basicSearch
    {

        public string MatUser_ProfileIDGN { get; set; }
        public string Matuser_ProfileloginID { get; set; }
        public string ErrormsgOrflg { get; set; }
        public string Age { get; set; }
        public string Profileid { get; set; }
        public string MatUser_Gender { get; set; }
        public int MatUser_ProfileForID { get; set; }
        public string ProfileforName { get; set; }
        public string Matuser_PhotoURL1 { get; set; }
        public string Matuser_PhotoURL2 { get; set; }
        public string Matuser_PhotoURL3 { get; set; }
        public string Matuser_PhotoURL4 { get; set; }
        public string Matuser_PhotoURL5 { get; set; }


        //Edit profile properties

        public int Matuser_ProfileheightID { get; set; }
        public string Comments { get; set; }
        public int? MatUser_MotherTongueID { get; set; }
        public int? Matuser_ReligionID { get; set; }
        public int Matuser_ProfileCasteID { get; set; }
        public int MatUser_ProfileRelCastSubcastID { get; set; }
        public string CityName { get; set; }
        public string Matuser_GothraName { get; set; }
        public string Matuser_SubcasteName { get; set; }
        public int CountryID { get; set; }
        public string State { get; set; }
        public string Matuser_Employmentdetails { get; set; }
        public int? Matuser_SalaryinLakhrupees { get; set; }
        public int? Matuser_EducationalID { get; set; }
        public string EmployerName { get; set; }
        public string FullName { get; set; }
        public string MatUser_FirstName { get; set; }
        public string MatUser_LastName { get; set; }
        public DateTime MatUser_DOB { get; set; }
        public int Matuser_Profileweightinkgs { get; set; }
        public double Matuser_Profileweightinlbs { get; set; }
        public int? MatUser_MaritalStatusID { get; set; }
        public int Matuser_BodyTypeID { get; set; }
        public int Matuser_ProfilecomplexionID { get; set; }
        public int? Matuser_ProfilephysicalstatusID { get; set; }
        public int Matuser_EatingID { get; set; }
        public int Matuser_DrinkingID { get; set; }
        public int? Matuser_SmokingID { get; set; }
        public string PhoneNumberTaggedToAddress { get; set; }
        public int? CntID { get; set; }
        public string EmailTaggedToAddress { get; set; }
        public int Matuser_ProfileStarID { get; set; }
        public string Matuser_Kujadoshamflag { get; set; }
        public int? Matuser_FamilyValuesID { get; set; }
        public int Matuser_FamilyTypeID { get; set; }
        public int? Matuser_FamilyStatusID { get; set; }
        public short? Matuser_FatherstatusID { get; set; }
        public string Matuser_ProfilePassword { get; set; }


        //Strings of dropdown values

        public string Matuser_Religionname { get; set; }
        public string Matuser_MotherTongueLanguage { get; set; }
        public string Matuser_Castename { get; set; }
        public string Matuser_highestqualification { get; set; }
        public string Matuser_Profileheightinftinches { get; set; }
        public string Matuser_MaritalStatusdesc { get; set; }
        public string Matuser_BodyType1 { get; set; }
        public string Matuser_Profilecomplexionname { get; set; }
        public string Matuser_EatingStatusdesc { get; set; }
        public string Matuser_DrinkingStatusdesc { get; set; }
        public string Matuser_SmokingStatusdesc { get; set; }
        public string Matuser_ProfileStarName { get; set; }
        public string Matuser_Familyvalues { get; set; }
        public string Matuser_FamilyType { get; set; }
        public string Matuser_FamilyStatus { get; set; }
        public string Matuser_Fatherstatusdesc { get; set; }
        public string CountryName { get; set; }
        public string Matuser_Profilephysicalstatusdesc { get; set; }

        //Advanced search

        public int nMinHeightID { get; set; }
        public int nMaxHeightID { get; set; }
        public int fromAge { get; set; }
        public int toAge { get; set; }
        public int GothramID { get; set; }
        public int MatUser_OccupationalID { get; set; }
        public string Affluent { get; set; }
        public string Enjoysmusic { get; set; }
        public string WarmFrnd { get; set; }
        public string Cheerful { get; set; }
        public string Likesphoto { get; set; }
        public string Enjoyfod { get; set; }
        public string Welledu { get; set; }
        public string Spiritual { get; set; }
        public string Attract { get; set; }
        public string Loving { get; set; }
        public string Likart { get; set; }
        public string Likenat { get; set; }
        public string Familyori { get; set; }
        public string Health { get; set; }
        public string Teet { get; set; }
        public string Cares { get; set; }
        public string reading { get; set; }
        public string litera { get; set; }
        public string kujadosham { get; set; }
        public int ResidentstatusID { get; set; }
        public int Matuser_ResidentstatusID { get; set; }
        public string AgeHeight { get; set; }
    }

    public class Messagesender
    {
        public int Matuser_MessageSenderID { get; set; }

        public string Matuser_ReceiverProfileID { get; set; }

        public string Matuser_SenderProfileID { get; set; }

        public int Matuser_Messagetypeid { get; set; }

        public int Matuser_ReqacceptancestatusID { get; set; }

        public int Matuser_ReadstatusID { get; set; }

        public string Matuser_Message { get; set; }

        public DateTime Matuser_sentts { get; set; }

        public char Matuser_Firsttimeflag { get; set; }

        public string ErrormsgOrflg { get; set; }
    }
    public class MessageReceiver
    {
        public int Matuser_MessageReceiverID { get; set; }

        public string Matuser_ReceiverProfileID { get; set; }

        public string Matuser_SenderProfileID { get; set; }

        public int Matuser_Messagetypeid { get; set; }

        public int Matuser_ReqacceptancestatusID { get; set; }

        public int Matuser_ReadstatusID { get; set; }

        public string Matuser_Message { get; set; }

        public DateTime Matuser_Receivedts { get; set; }

        public char Matuser_Firsttimeflag { get; set; }

        public string ErrormsgOrflg { get; set; }
    }

    public class messagecount
    {
        public string custid { get; set; }
        public int Archivedcount { get; set; }
        public int Sentcount { get; set; }
        public int Receivedcount { get; set; }
        public int Interestedcount { get; set; }
    }

    public class Displaymessages
    {
        public string username { get; set; }
        public string sendusrid { get; set; }
        public string sendusruniqueid { get; set; }
        public string sendusridh { get; set; }
        public string sendrid { get; set; }
        public DateTime recevdtime { get; set; }
        public string message { get; set; }
        public string displaytext { get; set; }
        public string messgdisplytext { get; set; }
    }

    public class DisplaymessagesList
    {
        public List<Displaymessages> receusrdisgrp { get; set; }
        public List<Displaymessages> Sentusrdisgrp { get; set; }
        public List<Displaymessages> recearchiveusrdisgrp { get; set; }
        public List<Displaymessages> sendarchiveusrarcvdgrp { get; set; }
        public List<Displaymessages> Intrestedprofiles { get; set; }
    }
}