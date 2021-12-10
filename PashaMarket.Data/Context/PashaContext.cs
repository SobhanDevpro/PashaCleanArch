using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PashaMarket.Domain.Entities.Account;
using PashaMarket.Domain.Entities.ProductOrder;
using PashaMarket.Domain.Entities.Products;
using PashaMarket.Domain.Entities.Site;

namespace PashaMarket.Data.Context
{
    public class PashaContext : DbContext
    {
        public PashaContext(DbContextOptions<PashaContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<SiteBanner> SiteBanners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed data category

            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 1,
                Title = "کالای دیجیتال",
                UrlName = "Electronic-Devices",
                IsActive = true,
                IsDelete = false
            }, new ProductCategory()
            {
                Id = 2,
                Title = "گوشی موبایل",
                UrlName = "Mobile-Phone",
                IsActive = true,
                IsDelete = false,
                ParentId = 1
            }, new ProductCategory()
            {
                Id = 3,
                Title = "لپ تاپ",
                UrlName = "NoteBook",
                IsActive = true,
                IsDelete = false,
                ParentId = 1
            }, new ProductCategory()
            {
                Id = 4,
                Title = "دوربین",
                UrlName = "Camera",
                IsActive = true,
                IsDelete = false,
                ParentId = 1
            }, new ProductCategory()
            {
                Id = 5,
                Title = "خانه و آشپزخانه",
                UrlName = "Home-And-Kitchen",
                IsActive = true,
                IsDelete = false
            }, new ProductCategory()
            {
                Id = 6,
                Title = "صوتی و تصویری",
                UrlName = "Video-Audio-Entertainment",
                IsActive = true,
                IsDelete = false,
                ParentId = 5
            }, new ProductCategory()
            {
                Id = 7,
                Title = "لوازم برقی خانگی",
                UrlName = "Home-Appliance",
                IsActive = true,
                IsDelete = false,
                ParentId = 5
            }
            );

            #endregion

            #region seed data products

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                Title = "دوربین دیجیتال نیکون مدل D3200 با لنز 18-55 F/3.5-5.6G ED II",
                ShortDescription = "این دوربین مناسب عکاسانی می‌باشد که یا تازه قصد دارند پا به عرصه‌ی عکاسی با دوربین‌های DSLR بگذارند و یا اینکه ابعاد بزرگ و قیمت بالای دوربین‌های رده‌ی Prosumer (مثل D7000) را نمی‌پسندند.",
                Description = "D3200 از نظر سطح رقابتی چیزی هم رده‌ی دوربین Canon EOS 600D و البته رقیب آن قرار می‌گیرد. با این حال D3200 ویژگی‌هایی دارد که در بین دوربین‌های DSLR هم رده کاملا نوین محسوب می‌شود. نخستین آن‌ها سنسور تصویر 24 مگا پیکسلی است. تا به این تاریخ DSLR ی در این رده، با این رزولوشن بالا ساخته نشده بود. در ضمن این دوربین برای نخستین بار در بین دوربین‌های این کلاس، از یونیت قابل انتخاب Wi-Fi مدل WU-1a هم پشتیبانی می‌کند. این دوربین اکنون توانایی ضبط ویدیویی 1080p Full HD در 30 فریم بر ثانیه را دارد و نمایشگر 3 اینچی آن نیز رزولوشن 921,000 پیکسل را ارائه می‌دهد.",
                ImageName = "15e24b7479ab46fda23371183e6fa82b.jpg",
                Price = 13400000,
                IsActive = true,
                IsDelete = false,
                Inventory = 25,

            }, new Product()
            {
                Id = 2,
                Title = "لپ تاپ 13.3 اینچی اچ پی مدل Spectre 13T AW200-B",
                ShortDescription = "Spectre x360 13t-AW200-B شرکت «اچ‌پی» یکی از زیباترین و جذاب‌ترین آلترابوک‌هایی محسوب می‌شود که تا کنون تولید شده است.",
                Description = "از طراحی بدنهGem Cut نسل جدید Spectre های HP، لولاها، محل قرارگیری پورت‌ها، کیبورد و اسپیکرها گرفته تا رنگ‌بندی لوکس آن، همه‌چیز دست به دست هم داده‌اند تا با یک محصول کامل سروکار داشته باشیم. بدنه‌ی این آلترابوک با آلومینیوم ماشین‌کاری شده CNC در قسمت‌ رویی و فیبر کربن در قسمت‌های زیرین ساخته شده و تنها 1.3 کیلوگرم وزن و 16 میلی‌متر ضخامت دارد؛ ضخامتی به اندازه‌ی یک خودکار معمولی. لولاهای متصل‌کننده صفحه‌نمایش به بدنه هم طراحی عالی دارند و به کم‌شدن این ضخامت کمک شایانی کرده‌اند. صفحه‌نمایش ۱۳.۳ اینچی این آلترابوک پنل IPS با وضوح Full HD و روکش براق دارد و توسط لایه‌ی محافظ Corning Gorilla Glass هم پوشانده شده است، همچنین بابهره مندی از تکنولوژی HP Sure View فشردن یک کلید بر روی کیبورد، زاویه دید صفحه نمایش را بسیار محدود کرده و فقط برای کاربر قابل دیدن است و از اطراف هیچ دیدی نخواهد داشت. ",
                ImageName = "4f7120a32fc7441fbd83456b01a15ca3.jpg",
                Price = 49700000,
                IsActive = true,
                IsDelete = false,
                Inventory = 12
            }, new Product()
            {
                Id = 3,
                Title = "گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS",
                ShortDescription = " گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت از به‌روزترین و باکیفیت‌ترین گوشی‌های موجود در بازار است طراحی زیبا و کارایی مناسبی دارد.",
                Description = "از ویژگی‌های این گوشی موبایل می‌توان به باتری لیتیوم یون با ظرفیت 5000 میلی‌آمپر اشاره کرد که این میزان شما را از شارژ مداوم گوشی موبایل بی‌نیاز می‌کند. این محصول قابلیت شارژ سریع با توان 25 وات را دارد و از فناوری شارژ سریع PD نسخه سوم پشتیبانی می‌کند. از دیگر قابلیت‌های گوشی Galaxy S21 Ultra 5G می‌توان به برخورداری از قابلیت شارژ بی‌سیم Qi/PMA با توان 15 وات اشاره کرد. دوربین 108 مگاپیکسلی این موبایل آن را برای انجام عکاسی حرفه‌ای هم به گزینه‌ای مناسب بدل کرده است. این گوشی قابلیت شارژ بی‌سیم دستگاه‌های دیگر (Power Bank/Reverse Wireless Charging) با توان 4.5 وات دارا است. گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت و رم 16 گیگابایت می‌تواند شگفت‌ترین گوشی سامسونگ باشد. در سری Galaxy S21 شارژر و هندزفری حذف شده است.",
                ImageName = "348e80b2dc954225952b14e120625904.jpg",
                Price = 33000000,
                IsActive = true,
                IsDelete = false,
                Inventory = 20
            }, new Product()
            {
                Id = 4,
                Title = "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ",
                ShortDescription = "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ محصولی بادوام و خوش‌ساخت از این برند است که امکانات متعددی را در اختیار کاربرانش می‌گذارد",
                Description = "کیفیت‌تصویر این تلویزیون 4K است و تصاویر را با وضوح و شفافیت بسیار بالایی نمایش می‌دهد. زاویه‌ دید وسیعی دارد و امکان تماشای صفحه‌نمایش را از محدوده‌ وسیعی فراهم می‌کند. نسبت تصویر آن 16:9 است و تصویر را با ابعاد متناسبی به پخش می‌گذارد. سیستم‌صوتی تلویزیون DSL-50K5700U دوکاناله است و به‌واسطه سیستم‌های صوتی بسیار قدرتمند Surround و Dolby Digital Plus می‌تواند کیفیت صدای بسیار مطلوبی را تولید کند. شرکت سازنده برای این مدل، دو عدد درگاه USB در نظر گرفته شده است. با استفاده از این 2 پورت می‌توانید فلش‌مموری و هارد اکسترنال خود را به تلویزیون متصل کرده و از فایل‌های موجود در آن‌ها استفاده کنید. برای اتصال پخش‌کننده‌ها به این تلویزیون می‌توانید از بین درگاه HDMI و کامپوزیت و کامپوننت یکی را انتخاب کنید. درگاه HDMI قادر است تصاویر را با کیفیت 4K به صفحه‌نمایش منتقل کند. از دیگر ویژگی‌های جالب این مدل، می‌توان به قابلیت ماشین زمان (Time Shift) اشاره کرد؛ کارایی این قابلیت به این صورت است که با ذخیره‌کردن برنامه‌ درحال‌پخش، می‌توانید به لحظات قبلی بازگردید. فرمت‌های تصویری قابل‌پشتیبانی این مدل بسیار متنوع است و به شما کمک می‌کند که به‌راحتی، فایل‌های دلخواه خود را به‌وسیله‌ی درگاه ارتباطی موردنظر پخش ‌کنید. این تلویزیون به‌همراه یک عدد ریموت ‌کنترل ارائه می‌شود که کارایی بسیار ساده‌ای دارد. تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ توانایی پخش و پشتیبانی از شبکه‌های تلویزیونی 4K و HD صدا و سیما را دارا است.",
                ImageName = "bbf9860cbccb4407a1806718e1a726aa.jpg",
                Price = 11500000,
                IsActive = true,
                IsDelete = false,
                Inventory = 8
            }, new Product()
            {
                Id = 5,
                Title = "تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ",
                ShortDescription = "برند دوو برند لوازم خانگی دوو برای اولین بار در سال 1963 در سئول کره‌ی جنوبی تأسیس شد. این برند یکی از مرغوب‌ترین و با کیفیت‌ترین برندهای لوازم خانگی است که در میان مصرف‌کنندگان طرفداران زیادی دارد.",
                Description = "تلویزیون‌ها هم مانند دیگر تولیدات کارخانه‌ها با پیشرفت تکنولوژی دستخوش تغییرات زیادی شده‌اند و در مدل‌های متنوع با قابلیت‌های متفاوت تولید می‌شوند. در این میان برند دوو یکی از تولیدکنندگان این کالای پرمصرف است که محصولاتش با استقبال بالایی مواجه شده‌اند. تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ، از گیرنده‌ی دیجیتالی و تيونر DVBT2 بهره می‌برد. کیفیت تصویر آن 4k-Ultra HD است و قابلیت Mega Contrast دارد. این تلویزیون با سه درگاه HDMI و دو درگاه USB امکان اتصال ابزارهای دیجیتال نظیر فلش و هارد از طریق پورت USB و یا اتصال Play Station و لپ تاپ را از طریق پورت HDMI برای کاربر فراهم می‌کند.",
                ImageName = "c0ce120897a74bbaa62969242d087f92.jpg",
                Price = 10500000,
                IsActive = true,
                IsDelete = false,
                Inventory = 12
            }

            );

            #endregion

            #region seed data productselectedcategories

            modelBuilder.Entity<ProductSelectedCategory>().HasData(new ProductSelectedCategory()
            {
                Id = 1,
                ProductId = 1,
                ProductCategoryId = 1,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 2,
                ProductId = 1,
                ProductCategoryId = 4,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 3,
                ProductId = 2,
                ProductCategoryId = 1,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 4,
                ProductId = 2,
                ProductCategoryId = 3,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 5,
                ProductId = 3,
                ProductCategoryId = 1,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 6,
                ProductId = 3,
                ProductCategoryId = 2,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 7,
                ProductId = 4,
                ProductCategoryId = 5,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 8,
                ProductId = 4,
                ProductCategoryId = 6,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 9,
                ProductId = 5,
                ProductCategoryId = 5,
                IsDelete = false
            }, new ProductSelectedCategory()
            {
                Id = 10,
                ProductId = 5,
                ProductCategoryId = 6,
                IsDelete = false
            }

            );

            #endregion

            #region seed data user

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 20,
                FirstName = "سبحان",
                LastName = "عزتی",
                IsEmailActive = true,
                Mobile = "09123456789",
                IsMobileActive = true,
                Password = "123456",
                IsActive = true,
                EmailActiveCode = "abc9b8cd546844839b97b1ecfb386b76",
                MobileActiveCode = "765989"
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
