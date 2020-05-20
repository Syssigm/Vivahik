namespace VivahikSearchApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbVivahik : DbContext
    {
        public dbVivahik()
            : base("name=dbVivahik")
        {
        }

        public virtual DbSet<MatAdBannerSize> MatAdBannerSizes { get; set; }
        public virtual DbSet<Matuser_AdDisplayImg> Matuser_AdDisplayImg { get; set; }
        public virtual DbSet<Matuser_Address> Matuser_Address { get; set; }
        public virtual DbSet<Matuser_AgeRange> Matuser_AgeRange { get; set; }
        public virtual DbSet<Matuser_Astrologicalprofile> Matuser_Astrologicalprofile { get; set; }
        public virtual DbSet<Matuser_BackgroundPersonalityInterests> Matuser_BackgroundPersonalityInterests { get; set; }
        public virtual DbSet<Matuser_BodyType> Matuser_BodyType { get; set; }
        public virtual DbSet<Matuser_Caste> Matuser_Caste { get; set; }
        public virtual DbSet<Matuser_Cntrycode> Matuser_Cntrycode { get; set; }
        public virtual DbSet<Matuser_ComplexionProfile> Matuser_ComplexionProfile { get; set; }
        public virtual DbSet<Matuser_Country> Matuser_Country { get; set; }
        public virtual DbSet<Matuser_DrinkingStatus> Matuser_DrinkingStatus { get; set; }
        public virtual DbSet<Matuser_EatingStatus> Matuser_EatingStatus { get; set; }
        public virtual DbSet<Matuser_Educationalprofile> Matuser_Educationalprofile { get; set; }
        public virtual DbSet<Matuser_EmploymentMaster> Matuser_EmploymentMaster { get; set; }
        public virtual DbSet<Matuser_Employmentprofile> Matuser_Employmentprofile { get; set; }
        public virtual DbSet<Matuser_FamilyProfile> Matuser_FamilyProfile { get; set; }
        public virtual DbSet<Matuser_FatherStatus> Matuser_FatherStatus { get; set; }
        public virtual DbSet<Matuser_HabitProfile> Matuser_HabitProfile { get; set; }
        public virtual DbSet<Matuser_HeightProfile> Matuser_HeightProfile { get; set; }
        public virtual DbSet<Matuser_Login> Matuser_Login { get; set; }
        public virtual DbSet<Matuser_Maritalstatus> Matuser_Maritalstatus { get; set; }
        public virtual DbSet<Matuser_Messagereadstatus> Matuser_Messagereadstatus { get; set; }
        public virtual DbSet<Matuser_MessageReceiver> Matuser_MessageReceiver { get; set; }
        public virtual DbSet<Matuser_Messagesender> Matuser_Messagesender { get; set; }
        public virtual DbSet<Matuser_Messagetype> Matuser_Messagetype { get; set; }
        public virtual DbSet<Matuser_MessRequestAccptStatus> Matuser_MessRequestAccptStatus { get; set; }
        public virtual DbSet<Matuser_Occupationalprofile> Matuser_Occupationalprofile { get; set; }
        public virtual DbSet<Matuser_Photo> Matuser_Photo { get; set; }
        public virtual DbSet<Matuser_PhysicalProfile> Matuser_PhysicalProfile { get; set; }
        public virtual DbSet<Matuser_PhysicalStatus> Matuser_PhysicalStatus { get; set; }
        public virtual DbSet<Matuser_Plan> Matuser_Plan { get; set; }
        public virtual DbSet<Matuser_Profile> Matuser_Profile { get; set; }
        public virtual DbSet<Matuser_Profilefor> Matuser_Profilefor { get; set; }
        public virtual DbSet<Matuser_ProfileTransaction> Matuser_ProfileTransaction { get; set; }
        public virtual DbSet<Matuser_Raasi> Matuser_Raasi { get; set; }
        public virtual DbSet<Matuser_Religion> Matuser_Religion { get; set; }
        public virtual DbSet<Matuser_ReligionProfile> Matuser_ReligionProfile { get; set; }
        public virtual DbSet<Matuser_ResidentStatus> Matuser_ResidentStatus { get; set; }
        public virtual DbSet<Matuser_SalaryRange> Matuser_SalaryRange { get; set; }
        public virtual DbSet<Matuser_SmokingStatus> Matuser_SmokingStatus { get; set; }
        public virtual DbSet<Matuser_Star> Matuser_Star { get; set; }
        public virtual DbSet<Matuser_UserLanguage> Matuser_UserLanguage { get; set; }
        public virtual DbSet<Matuser_WeightProfile> Matuser_WeightProfile { get; set; }
        public virtual DbSet<MatuserFamily_Status> MatuserFamily_Status { get; set; }
        public virtual DbSet<MatuserFamily_Type> MatuserFamily_Type { get; set; }
        public virtual DbSet<MatuserFamily_Values> MatuserFamily_Values { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatAdBannerSize>()
                .HasMany(e => e.Matuser_AdDisplayImg)
                .WithRequired(e => e.MatAdBannerSize)
                .HasForeignKey(e => e.Matuser_AdBannerSizeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matuser_AdDisplayImg>()
                .Property(e => e.Matuser_AdDisplayTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_AdDisplayImg>()
                .Property(e => e.Matuser_DisplayPageName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_AdDisplayImg>()
                .Property(e => e.Matuser_ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_AdDisplayImg>()
                .Property(e => e.Matuser_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_AdDisplayImg>()
                .Property(e => e.AdLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.PhoneNumberTaggedToAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.EmailTaggedToAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.BuildingNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.StreetName1)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.StreetName2)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.Zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Address>()
                .Property(e => e.AddressStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Astrologicalprofile>()
                .Property(e => e.Matuser_Kujadoshamflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Astrologicalprofile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgAffluentflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgEnjoysmusicflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgWarmFriendlyflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgCheerfulflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLikesphotographyflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgEnjoysfoodflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgWelleducatedflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgSpirituallyinclinedflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgAttractiveflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLovingflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLikesartflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLikesnatureflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgFamilyorientedflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgHealthconsciousflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgTeetotallerflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgCaresforpetsflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLikesreadingflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BackgroundPersonalityInterests>()
                .Property(e => e.Matuser_BgLikesliteratureflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_BodyType>()
                .Property(e => e.Matuser_BodyTypeDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Caste>()
                .Property(e => e.Matuser_Castename)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Caste>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ComplexionProfile>()
                .Property(e => e.Matuser_Profilecomplexionname)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ComplexionProfile>()
                .HasMany(e => e.Matuser_PhysicalProfile)
                .WithRequired(e => e.Matuser_ComplexionProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matuser_Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Educationalprofile>()
                .Property(e => e.Matuser_highestqualification)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_EmploymentMaster>()
                .Property(e => e.Matuser_Employmentdetails)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Employmentprofile>()
                .Property(e => e.Matuser_Employmentdetails)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Employmentprofile>()
                .Property(e => e.EmployerName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Employmentprofile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_FamilyProfile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_HabitProfile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_HeightProfile>()
                .Property(e => e.Matuser_Profileheightinftinches)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_HeightProfile>()
                .HasMany(e => e.Matuser_PhysicalProfile)
                .WithRequired(e => e.Matuser_HeightProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matuser_Login>()
                .Property(e => e.Matuser_ProfileloginID)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Login>()
                .Property(e => e.Matuser_ProfilePassword)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagereadstatus>()
                .Property(e => e.Matuser_Messagerequeststatus)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagereadstatus>()
                .HasMany(e => e.Matuser_MessageReceiver)
                .WithOptional(e => e.Matuser_Messagereadstatus)
                .HasForeignKey(e => e.Matuser_ReadstatusID);

            modelBuilder.Entity<Matuser_Messagereadstatus>()
                .HasMany(e => e.Matuser_Messagesender)
                .WithOptional(e => e.Matuser_Messagereadstatus)
                .HasForeignKey(e => e.Matuser_ReadstatusID);

            modelBuilder.Entity<Matuser_MessageReceiver>()
                .Property(e => e.Matuser_ReceiverProfileID)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_MessageReceiver>()
                .Property(e => e.Matuser_SenderProfileID)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_MessageReceiver>()
                .Property(e => e.Matuser_Message)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_MessageReceiver>()
                .Property(e => e.Matuser_Firsttimeflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagesender>()
                .Property(e => e.Matuser_ReceiverProfileID)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagesender>()
                .Property(e => e.Matuser_SenderProfileID)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagesender>()
                .Property(e => e.Matuser_Message)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagesender>()
                .Property(e => e.Matuser_Firsttimeflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Messagetype>()
                .Property(e => e.Matuser_Messagetype1)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_MessRequestAccptStatus>()
                .HasMany(e => e.Matuser_MessageReceiver)
                .WithOptional(e => e.Matuser_MessRequestAccptStatus)
                .HasForeignKey(e => e.Matuser_ReqacceptancestatusID);

            modelBuilder.Entity<Matuser_MessRequestAccptStatus>()
                .HasMany(e => e.Matuser_Messagesender)
                .WithOptional(e => e.Matuser_MessRequestAccptStatus)
                .HasForeignKey(e => e.Matuser_ReqacceptancestatusID);

            modelBuilder.Entity<Matuser_Occupationalprofile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_Phototititle)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_PhotoURL1)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_PhotoURL2)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_PhotoURL3)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_PhotoURL4)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.Matuser_PhotoURL5)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Photo>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_PhysicalProfile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_PhysicalStatus>()
                .Property(e => e.Matuser_Profilephysicalstatusdesc)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Plan>()
                .Property(e => e.Matuser_Planname)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Plan>()
                .Property(e => e.Matuser_activeflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Plan>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profile>()
                .Property(e => e.MatUser_FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profile>()
                .Property(e => e.MatUser_LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profile>()
                .Property(e => e.MatUser_Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profile>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Profilefor>()
                .Property(e => e.ProfileforName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ProfileTransaction>()
                .Property(e => e.Matuser_PartnerProfileStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Raasi>()
                .Property(e => e.Matuser_ProfileRaasiName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Raasi>()
                .HasMany(e => e.Matuser_Astrologicalprofile)
                .WithRequired(e => e.Matuser_Raasi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matuser_Religion>()
                .Property(e => e.Matuser_Religionname)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ReligionProfile>()
                .Property(e => e.Matuser_SubcasteName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ReligionProfile>()
                .Property(e => e.Matuser_GothraName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ReligionProfile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_ResidentStatus>()
                .Property(e => e.Matuser_Residentstatusdesc)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Star>()
                .Property(e => e.Matuser_ProfileStarName)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_Star>()
                .HasMany(e => e.Matuser_Astrologicalprofile)
                .WithRequired(e => e.Matuser_Star)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matuser_UserLanguage>()
                .Property(e => e.Matuser_MotherTongueLanguage)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_UserLanguage>()
                .Property(e => e.Langindicator)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_WeightProfile>()
                .Property(e => e.MatUser_ProfileIDGN)
                .IsUnicode(false);

            modelBuilder.Entity<Matuser_WeightProfile>()
                .HasMany(e => e.Matuser_PhysicalProfile)
                .WithRequired(e => e.Matuser_WeightProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatuserFamily_Type>()
                .Property(e => e.Matuser_FamilyType)
                .IsUnicode(false);

            modelBuilder.Entity<MatuserFamily_Values>()
                .Property(e => e.Matuser_Familyvalues)
                .IsUnicode(false);
        }
    }
}
