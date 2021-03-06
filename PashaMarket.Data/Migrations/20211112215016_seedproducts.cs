using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PashaMarket.Data.Migrations
{
    public partial class seedproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "Inventory", "IsActive", "IsDelete", "LastUpdateDate", "Price", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D3200 از نظر سطح رقابتی چیزی هم رده‌ی دوربین Canon EOS 600D و البته رقیب آن قرار می‌گیرد. با این حال D3200 ویژگی‌هایی دارد که در بین دوربین‌های DSLR هم رده کاملا نوین محسوب می‌شود. نخستین آن‌ها سنسور تصویر 24 مگا پیکسلی است. تا به این تاریخ DSLR ی در این رده، با این رزولوشن بالا ساخته نشده بود. در ضمن این دوربین برای نخستین بار در بین دوربین‌های این کلاس، از یونیت قابل انتخاب Wi-Fi مدل WU-1a هم پشتیبانی می‌کند. این دوربین اکنون توانایی ضبط ویدیویی 1080p Full HD در 30 فریم بر ثانیه را دارد و نمایشگر 3 اینچی آن نیز رزولوشن 921,000 پیکسل را ارائه می‌دهد.", "https://dkstatics-public.digikala.com/digikala-products/375537.jpg?x-oss-process=image/resize,h_1600/quality,q_80", 25, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13400000, "این دوربین مناسب عکاسانی می‌باشد که یا تازه قصد دارند پا به عرصه‌ی عکاسی با دوربین‌های DSLR بگذارند و یا اینکه ابعاد بزرگ و قیمت بالای دوربین‌های رده‌ی Prosumer (مثل D7000) را نمی‌پسندند.", "دوربین دیجیتال نیکون مدل D3200 با لنز 18-55 F/3.5-5.6G ED II" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "از طراحی بدنهGem Cut نسل جدید Spectre های HP، لولاها، محل قرارگیری پورت‌ها، کیبورد و اسپیکرها گرفته تا رنگ‌بندی لوکس آن، همه‌چیز دست به دست هم داده‌اند تا با یک محصول کامل سروکار داشته باشیم. بدنه‌ی این آلترابوک با آلومینیوم ماشین‌کاری شده CNC در قسمت‌ رویی و فیبر کربن در قسمت‌های زیرین ساخته شده و تنها 1.3 کیلوگرم وزن و 16 میلی‌متر ضخامت دارد؛ ضخامتی به اندازه‌ی یک خودکار معمولی. لولاهای متصل‌کننده صفحه‌نمایش به بدنه هم طراحی عالی دارند و به کم‌شدن این ضخامت کمک شایانی کرده‌اند. صفحه‌نمایش ۱۳.۳ اینچی این آلترابوک پنل IPS با وضوح Full HD و روکش براق دارد و توسط لایه‌ی محافظ Corning Gorilla Glass هم پوشانده شده است، همچنین بابهره مندی از تکنولوژی HP Sure View فشردن یک کلید بر روی کیبورد، زاویه دید صفحه نمایش را بسیار محدود کرده و فقط برای کاربر قابل دیدن است و از اطراف هیچ دیدی نخواهد داشت. ", "https://dkstatics-public.digikala.com/digikala-products/5e8fa7643191102d9043e93343367d3eef5dcb70_1622545845.jpg?x-oss-process=image/resize,h_1600/quality,q_80/watermark,image_ZGstdy8xLnBuZw==,t_90,g_nw,x_15,y_15", 12, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49700000, "Spectre x360 13t-AW200-B شرکت «اچ‌پی» یکی از زیباترین و جذاب‌ترین آلترابوک‌هایی محسوب می‌شود که تا کنون تولید شده است.", "لپ تاپ 13.3 اینچی اچ پی مدل Spectre 13T AW200-B" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "از ویژگی‌های این گوشی موبایل می‌توان به باتری لیتیوم یون با ظرفیت 5000 میلی‌آمپر اشاره کرد که این میزان شما را از شارژ مداوم گوشی موبایل بی‌نیاز می‌کند. این محصول قابلیت شارژ سریع با توان 25 وات را دارد و از فناوری شارژ سریع PD نسخه سوم پشتیبانی می‌کند. از دیگر قابلیت‌های گوشی Galaxy S21 Ultra 5G می‌توان به برخورداری از قابلیت شارژ بی‌سیم Qi/PMA با توان 15 وات اشاره کرد. دوربین 108 مگاپیکسلی این موبایل آن را برای انجام عکاسی حرفه‌ای هم به گزینه‌ای مناسب بدل کرده است. این گوشی قابلیت شارژ بی‌سیم دستگاه‌های دیگر (Power Bank/Reverse Wireless Charging) با توان 4.5 وات دارا است. گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت و رم 16 گیگابایت می‌تواند شگفت‌ترین گوشی سامسونگ باشد. در سری Galaxy S21 شارژر و هندزفری حذف شده است.", "https://dkstatics-public.digikala.com/digikala-products/62c8a2c6d57dce6efbde8bbd348490c2f10a55e1_1611742801.jpg?x-oss-process=image/resize,h_1600/quality,q_80/watermark,image_ZGstdy8xLnBuZw==,t_90,g_nw,x_15,y_15", 20, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33000000, " گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS دو سیم کارت ظرفیت 512 گیگابایت از به‌روزترین و باکیفیت‌ترین گوشی‌های موجود در بازار است طراحی زیبا و کارایی مناسبی دارد.", "گوشی موبایل سامسونگ مدل Galaxy S21 Ultra 5G SM-G998B/DS" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کیفیت‌تصویر این تلویزیون 4K است و تصاویر را با وضوح و شفافیت بسیار بالایی نمایش می‌دهد. زاویه‌ دید وسیعی دارد و امکان تماشای صفحه‌نمایش را از محدوده‌ وسیعی فراهم می‌کند. نسبت تصویر آن 16:9 است و تصویر را با ابعاد متناسبی به پخش می‌گذارد. سیستم‌صوتی تلویزیون DSL-50K5700U دوکاناله است و به‌واسطه سیستم‌های صوتی بسیار قدرتمند Surround و Dolby Digital Plus می‌تواند کیفیت صدای بسیار مطلوبی را تولید کند. شرکت سازنده برای این مدل، دو عدد درگاه USB در نظر گرفته شده است. با استفاده از این 2 پورت می‌توانید فلش‌مموری و هارد اکسترنال خود را به تلویزیون متصل کرده و از فایل‌های موجود در آن‌ها استفاده کنید. برای اتصال پخش‌کننده‌ها به این تلویزیون می‌توانید از بین درگاه HDMI و کامپوزیت و کامپوننت یکی را انتخاب کنید. درگاه HDMI قادر است تصاویر را با کیفیت 4K به صفحه‌نمایش منتقل کند. از دیگر ویژگی‌های جالب این مدل، می‌توان به قابلیت ماشین زمان (Time Shift) اشاره کرد؛ کارایی این قابلیت به این صورت است که با ذخیره‌کردن برنامه‌ درحال‌پخش، می‌توانید به لحظات قبلی بازگردید. فرمت‌های تصویری قابل‌پشتیبانی این مدل بسیار متنوع است و به شما کمک می‌کند که به‌راحتی، فایل‌های دلخواه خود را به‌وسیله‌ی درگاه ارتباطی موردنظر پخش ‌کنید. این تلویزیون به‌همراه یک عدد ریموت ‌کنترل ارائه می‌شود که کارایی بسیار ساده‌ای دارد. تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ توانایی پخش و پشتیبانی از شبکه‌های تلویزیونی 4K و HD صدا و سیما را دارا است.", "https://dkstatics-public.digikala.com/digikala-products/984b3a27a180c6174a82b8e84a457731f414e082_1611138377.jpg?x-oss-process=image/resize,h_1600/quality,q_80/watermark,image_ZGstdy8xLnBuZw==,t_90,g_nw,x_15,y_15", 8, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11500000, "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ محصولی بادوام و خوش‌ساخت از این برند است که امکانات متعددی را در اختیار کاربرانش می‌گذارد", "تلویزیون ال ای دی هوشمند دوو مدل DSL-50K5700U سایز 50 اینچ" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تلویزیون‌ها هم مانند دیگر تولیدات کارخانه‌ها با پیشرفت تکنولوژی دستخوش تغییرات زیادی شده‌اند و در مدل‌های متنوع با قابلیت‌های متفاوت تولید می‌شوند. در این میان برند دوو یکی از تولیدکنندگان این کالای پرمصرف است که محصولاتش با استقبال بالایی مواجه شده‌اند. تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ، از گیرنده‌ی دیجیتالی و تيونر DVBT2 بهره می‌برد. کیفیت تصویر آن 4k-Ultra HD است و قابلیت Mega Contrast دارد. این تلویزیون با سه درگاه HDMI و دو درگاه USB امکان اتصال ابزارهای دیجیتال نظیر فلش و هارد از طریق پورت USB و یا اتصال Play Station و لپ تاپ را از طریق پورت HDMI برای کاربر فراهم می‌کند.", "https://dkstatics-public.digikala.com/digikala-products/ecfcb59ed781a44b0cbb2c6b66459c38f6518fe7_1607924864.jpg?x-oss-process=image/resize,h_1600/quality,q_80/watermark,image_ZGstdy8xLnBuZw==,t_90,g_nw,x_15,y_15", 12, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10500000, "برند دوو برند لوازم خانگی دوو برای اولین بار در سال 1963 در سئول کره‌ی جنوبی تأسیس شد. این برند یکی از مرغوب‌ترین و با کیفیت‌ترین برندهای لوازم خانگی است که در میان مصرف‌کنندگان طرفداران زیادی دارد.", "تلویزیون ال ای دی دوو مدل DLE-50K4310U سایز 50 اینچ" }
                });

            migrationBuilder.InsertData(
                table: "ProductSelectedCategories",
                columns: new[] { "Id", "CreateDate", "IsDelete", "LastUpdateDate", "ProductCategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSelectedCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
