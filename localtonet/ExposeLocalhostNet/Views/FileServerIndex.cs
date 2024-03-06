using System;
using System.CodeDom.Compiler;
using System.Linq;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet.Views
{
	// Token: 0x02000018 RID: 24
	[GeneratedCode("RazorTemplatePreprocessor", "17.5.0.172")]
	public class FileServerIndex : FileServerIndexBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000096A7 File Offset: 0x000078A7
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000096AF File Offset: 0x000078AF
		public FileServerIndexModel Model { get; set; }

		// Token: 0x0600008F RID: 143 RVA: 0x000096B8 File Offset: 0x000078B8
		public override void Execute()
		{
			base.WriteLiteral("<!DOCTYPE html>\r\n<html");
			base.WriteLiteral(" lang=\"en\"");
			base.WriteLiteral(">\r\n<head>\r\n    <title>");
			base.Write(this.Model.Title);
			base.WriteLiteral("</title>\r\n    <meta");
			base.WriteLiteral(" charset=\"utf-8\"");
			base.WriteLiteral(" />\r\n    <meta");
			base.WriteLiteral(" name=\"viewport\"");
			base.WriteLiteral(" content=\"width=device-width, initial-scale=1\"");
			base.WriteLiteral(" />\r\n    <meta");
			base.WriteLiteral(" property=\"og:title\"");
			base.WriteAttribute("content", " content=\"", "\"", new Tuple<string, object, bool>[]
			{
				Tuple.Create<string, object, bool>("", this.Model.Title, false)
			});
			base.WriteLiteral(" />\r\n    <link");
			base.WriteAttribute("href", " href=\"", "\"", new Tuple<string, object, bool>[]
			{
				Tuple.Create<string, object, bool>("", this.Model.FaviconPath, false)
			});
			base.WriteLiteral(" rel=\"shortcut icon\"");
			base.WriteLiteral(" />\r\n    <link");
			base.WriteLiteral(" href=\"https://fonts.googleapis.com/css?family=Inter:300,400,500,600,700\"");
			base.WriteLiteral(" rel=\"stylesheet\"");
			base.WriteLiteral(" />\r\n    <link");
			base.WriteLiteral(" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css\"");
			base.WriteLiteral(" rel=\"stylesheet\"");
			base.WriteLiteral(">\r\n    <link");
			base.WriteLiteral(" href=\"https://cdn.localtonet.com/fileserver/css/datatables.bundle.css\"");
			base.WriteLiteral(" rel=\"stylesheet\"");
			base.WriteLiteral(" type=\"text/css\"");
			base.WriteLiteral(" />\r\n    <link");
			base.WriteLiteral(" href=\"https://cdn.localtonet.com/fileserver/css/plugins.bundle.css\"");
			base.WriteLiteral(" rel=\"stylesheet\"");
			base.WriteLiteral(" type=\"text/css\"");
			base.WriteLiteral(" />\r\n    <link");
			base.WriteLiteral(" href=\"https://cdn.localtonet.com/fileserver/css/style.bundle.css\"");
			base.WriteLiteral(" rel=\"stylesheet\"");
			base.WriteLiteral(" type=\"text/css\"");
			base.WriteLiteral(" />\r\n</head>\r\n<body");
			base.WriteLiteral(" id=\"kt_body\"");
			base.WriteLiteral(">\r\n    <script>var defaultThemeMode = \"light\"; var themeMode; if (document.documentElement) { if (document.documentElement.hasAttribute(\"data-theme-mode\")) { themeMode = document.documentElement.getAttribute(\"data-theme-mode\"); } else { if (localStorage.getItem(\"data-theme\") !== null) { themeMode = localStorage.getItem(\"data-theme\"); } else { themeMode = defaultThemeMode; } } if (themeMode === \"system\") { themeMode = window.matchMedia(\"(prefers-color-scheme: dark)\").matches ? \"dark\" : \"light\"; } document.documentElement.setAttribute(\"data-theme\", themeMode); }</script>\r\n    <div");
			base.WriteLiteral(" class=\"d-flex flex-column flex-root\"");
			base.WriteLiteral(">\r\n        <div");
			base.WriteLiteral(" class=\"page d-flex flex-row flex-column-fluid\"");
			base.WriteLiteral(">\r\n            <div");
			base.WriteLiteral(" class=\"wrapper d-flex flex-column flex-row-fluid\"");
			base.WriteLiteral(" id=\"kt_wrapper\"");
			base.WriteLiteral(" style=\"padding-left: 0%;\"");
			base.WriteLiteral(">\r\n                <div");
			base.WriteLiteral(" id=\"kt_header\"");
			base.WriteLiteral(" class=\"header\"");
			base.WriteLiteral(">\r\n                    <div");
			base.WriteLiteral(" class=\"container-fluid d-flex align-items-center flex-wrap justify-content-between\"");
			base.WriteLiteral(" id=\"kt_header_container\"");
			base.WriteLiteral(">\r\n                        <div");
			base.WriteLiteral(" class=\"page-title d-flex flex-column align-items-start justify-content-center flex-wrap me-2 pb-5 pb-lg-0 pt-7 pt-lg-0\"");
			base.WriteLiteral(" data-kt-swapper=\"true\"");
			base.WriteLiteral(" data-kt-swapper-mode=\"prepend\"");
			base.WriteLiteral(" data-kt-swapper-parent=\"{default: '#kt_content_container', lg: '#kt_header_container'}\"");
			base.WriteLiteral(">\r\n                            <h1");
			base.WriteLiteral(" class=\"d-flex flex-column text-dark fw-bold my-0 fs-1\"");
			base.WriteLiteral(">");
			base.Write(this.Model.Title);
			base.WriteLiteral("</h1>\r\n                            <ul");
			base.WriteLiteral(" class=\"breadcrumb breadcrumb-dot fw-semibold fs-base my-1\"");
			base.WriteLiteral(">\r\n                                <li");
			base.WriteLiteral(" class=\"breadcrumb-item text-muted\"");
			base.WriteLiteral(">");
			base.Write(this.Model.UserName);
			base.WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                        <div");
			base.WriteLiteral(" class=\"d-flex d-lg-none align-items-center ms-n3 me-2\"");
			base.WriteLiteral(">\r\n                            <div");
			base.WriteLiteral(" class=\"btn btn-icon btn-active-icon-primary\"");
			base.WriteLiteral(" id=\"kt_aside_toggle\"");
			base.WriteLiteral(">\r\n                                <a");
			base.WriteLiteral(" href=\"/\"");
			base.WriteLiteral(">\r\n                                    <img");
			base.WriteLiteral(" alt=\"Logo\"");
			base.WriteAttribute("src", " src=\"", "\"", new Tuple<string, object, bool>[]
			{
				Tuple.Create<string, object, bool>("", this.Model.LogoFile, false)
			});
			base.WriteLiteral(" class=\"h-30px logo theme-light-show\"");
			base.WriteLiteral(" />\r\n                                    <img");
			base.WriteLiteral(" alt=\"Logo\"");
			base.WriteAttribute("src", " src=\"", "\"", new Tuple<string, object, bool>[]
			{
				Tuple.Create<string, object, bool>("", this.Model.LogoFile, false)
			});
			base.WriteLiteral(" class=\"h-30px logo theme-dark-show\"");
			base.WriteLiteral(" />\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                        <div");
			base.WriteLiteral(" class=\"d-flex align-items-center flex-shrink-0\"");
			base.WriteLiteral(">\r\n                            <div");
			base.WriteLiteral(" class=\"d-flex align-items-center ms-3 ms-lg-4\"");
			base.WriteLiteral(">\r\n");
			if (this.Model.IsAuth)
			{
				if (!string.IsNullOrEmpty(this.Model.UserName))
				{
					base.WriteLiteral("                                        <a");
					base.WriteLiteral(" href=\"javascript:;\"");
					base.WriteLiteral(" class=\"btn btn-icon btn-color-gray-700 btn-active-color-primary btn-outline w-100px h-40px me-3\"");
					base.WriteLiteral(" onclick=\"logOut();\"");
					base.WriteLiteral(">Log Out</a>\r\n");
				}
				if (this.Model.HaveUserPermissions && string.IsNullOrEmpty(this.Model.UserName))
				{
					base.WriteLiteral("                                        <a");
					base.WriteLiteral(" href=\"/SignOT3YUsadhd7qPuALBinhnsDdAUint4\"");
					base.WriteLiteral(" class=\"btn btn-icon btn-color-gray-700 btn-active-color-primary btn-outline w-100px h-40px me-3\"");
					base.WriteLiteral(">Sign In</a>\r\n");
				}
			}
			else if (this.Model.CanEveryoneReadAccess)
			{
				base.WriteLiteral("                                        <a");
				base.WriteLiteral(" href=\"javascript:;\"");
				base.WriteLiteral(" class=\"btn btn-icon btn-color-gray-700 btn-active-color-primary btn-outline w-200px h-40px me-3\"");
				base.WriteLiteral(" onclick=\"loginAsGuest();\"");
				base.WriteLiteral(">Login as Guest</a>\r\n");
			}
			base.WriteLiteral("                                <a");
			base.WriteLiteral(" href=\"#\"");
			base.WriteLiteral(" class=\"btn btn-icon btn-color-gray-700 btn-active-color-primary btn-outline w-40px h-40px\"");
			base.WriteLiteral(" data-kt-menu-trigger=\"{default:'click', lg: 'hover'}\"");
			base.WriteLiteral(" data-kt-menu-attach=\"parent\"");
			base.WriteLiteral(" data-kt-menu-placement=\"bottom-end\"");
			base.WriteLiteral(">\r\n                                    <span");
			base.WriteLiteral(" class=\"svg-icon theme-light-show svg-icon-2\"");
			base.WriteLiteral(">\r\n                                        <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                                            <path");
			base.WriteLiteral(" d=\"M11.9905 5.62598C10.7293 5.62574 9.49646 5.9995 8.44775 6.69997C7.39903 7.40045 6.58159 8.39619 6.09881 9.56126C5.61603 10.7263 5.48958 12.0084 5.73547 13.2453C5.98135 14.4823 6.58852 15.6185 7.48019 16.5104C8.37186 17.4022 9.50798 18.0096 10.7449 18.2557C11.9818 18.5019 13.2639 18.3757 14.429 17.8931C15.5942 17.4106 16.5901 16.5933 17.2908 15.5448C17.9915 14.4962 18.3655 13.2634 18.3655 12.0023C18.3637 10.3119 17.6916 8.69129 16.4964 7.49593C15.3013 6.30056 13.6808 5.62806 11.9905 5.62598Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M22.1258 10.8771H20.627C20.3286 10.8771 20.0424 10.9956 19.8314 11.2066C19.6204 11.4176 19.5018 11.7038 19.5018 12.0023C19.5018 12.3007 19.6204 12.5869 19.8314 12.7979C20.0424 13.0089 20.3286 13.1274 20.627 13.1274H22.1258C22.4242 13.1274 22.7104 13.0089 22.9214 12.7979C23.1324 12.5869 23.2509 12.3007 23.2509 12.0023C23.2509 11.7038 23.1324 11.4176 22.9214 11.2066C22.7104 10.9956 22.4242 10.8771 22.1258 10.8771Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M11.9905 19.4995C11.6923 19.5 11.4064 19.6187 11.1956 19.8296C10.9848 20.0405 10.8663 20.3265 10.866 20.6247V22.1249C10.866 22.4231 10.9845 22.7091 11.1953 22.9199C11.4062 23.1308 11.6922 23.2492 11.9904 23.2492C12.2886 23.2492 12.5746 23.1308 12.7854 22.9199C12.9963 22.7091 13.1147 22.4231 13.1147 22.1249V20.6247C13.1145 20.3265 12.996 20.0406 12.7853 19.8296C12.5745 19.6187 12.2887 19.5 11.9905 19.4995Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M4.49743 12.0023C4.49718 11.704 4.37865 11.4181 4.16785 11.2072C3.95705 10.9962 3.67119 10.8775 3.37298 10.8771H1.87445C1.57603 10.8771 1.28984 10.9956 1.07883 11.2066C0.867812 11.4176 0.749266 11.7038 0.749266 12.0023C0.749266 12.3007 0.867812 12.5869 1.07883 12.7979C1.28984 13.0089 1.57603 13.1274 1.87445 13.1274H3.37299C3.6712 13.127 3.95706 13.0083 4.16785 12.7973C4.37865 12.5864 4.49718 12.3005 4.49743 12.0023Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M11.9905 4.50058C12.2887 4.50012 12.5745 4.38141 12.7853 4.17048C12.9961 3.95954 13.1147 3.67361 13.1149 3.3754V1.87521C13.1149 1.57701 12.9965 1.29103 12.7856 1.08017C12.5748 0.869313 12.2888 0.750854 11.9906 0.750854C11.6924 0.750854 11.4064 0.869313 11.1955 1.08017C10.9847 1.29103 10.8662 1.57701 10.8662 1.87521V3.3754C10.8664 3.67359 10.9849 3.95952 11.1957 4.17046C11.4065 4.3814 11.6923 4.50012 11.9905 4.50058Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M18.8857 6.6972L19.9465 5.63642C20.0512 5.53209 20.1343 5.40813 20.1911 5.27163C20.2479 5.13513 20.2772 4.98877 20.2774 4.84093C20.2775 4.69309 20.2485 4.54667 20.192 4.41006C20.1355 4.27344 20.0526 4.14932 19.948 4.04478C19.8435 3.94024 19.7194 3.85734 19.5828 3.80083C19.4462 3.74432 19.2997 3.71531 19.1519 3.71545C19.0041 3.7156 18.8577 3.7449 18.7212 3.80167C18.5847 3.85845 18.4607 3.94159 18.3564 4.04633L17.2956 5.10714C17.1909 5.21147 17.1077 5.33543 17.0509 5.47194C16.9942 5.60844 16.9649 5.7548 16.9647 5.90264C16.9646 6.05048 16.9936 6.19689 17.0501 6.33351C17.1066 6.47012 17.1895 6.59425 17.294 6.69878C17.3986 6.80332 17.5227 6.88621 17.6593 6.94272C17.7959 6.99923 17.9424 7.02824 18.0902 7.02809C18.238 7.02795 18.3844 6.99865 18.5209 6.94187C18.6574 6.88509 18.7814 6.80195 18.8857 6.6972Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M18.8855 17.3073C18.7812 17.2026 18.6572 17.1195 18.5207 17.0627C18.3843 17.006 18.2379 16.9767 18.0901 16.9766C17.9423 16.9764 17.7959 17.0055 17.6593 17.062C17.5227 17.1185 17.3986 17.2014 17.2941 17.3059C17.1895 17.4104 17.1067 17.5345 17.0501 17.6711C16.9936 17.8077 16.9646 17.9541 16.9648 18.1019C16.9649 18.2497 16.9942 18.3961 17.0509 18.5326C17.1077 18.6691 17.1908 18.793 17.2955 18.8974L18.3563 19.9582C18.4606 20.0629 18.5846 20.146 18.721 20.2027C18.8575 20.2595 19.0039 20.2887 19.1517 20.2889C19.2995 20.289 19.4459 20.26 19.5825 20.2035C19.7191 20.147 19.8432 20.0641 19.9477 19.9595C20.0523 19.855 20.1351 19.7309 20.1916 19.5943C20.2482 19.4577 20.2772 19.3113 20.277 19.1635C20.2769 19.0157 20.2476 18.8694 20.1909 18.7329C20.1341 18.5964 20.051 18.4724 19.9463 18.3681L18.8855 17.3073Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M5.09528 17.3072L4.0345 18.368C3.92972 18.4723 3.84655 18.5963 3.78974 18.7328C3.73294 18.8693 3.70362 19.0156 3.70346 19.1635C3.7033 19.3114 3.7323 19.4578 3.78881 19.5944C3.84532 19.7311 3.92822 19.8552 4.03277 19.9598C4.13732 20.0643 4.26147 20.1472 4.3981 20.2037C4.53473 20.2602 4.68117 20.2892 4.82902 20.2891C4.97688 20.2889 5.12325 20.2596 5.25976 20.2028C5.39627 20.146 5.52024 20.0628 5.62456 19.958L6.68536 18.8973C6.79007 18.7929 6.87318 18.6689 6.92993 18.5325C6.98667 18.396 7.01595 18.2496 7.01608 18.1018C7.01621 17.954 6.98719 17.8076 6.93068 17.671C6.87417 17.5344 6.79129 17.4103 6.68676 17.3058C6.58224 17.2012 6.45813 17.1183 6.32153 17.0618C6.18494 17.0053 6.03855 16.9763 5.89073 16.9764C5.74291 16.9766 5.59657 17.0058 5.46007 17.0626C5.32358 17.1193 5.19962 17.2024 5.09528 17.3072Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M5.09541 6.69715C5.19979 6.8017 5.32374 6.88466 5.4602 6.94128C5.59665 6.9979 5.74292 7.02708 5.89065 7.02714C6.03839 7.0272 6.18469 6.99815 6.32119 6.94164C6.45769 6.88514 6.58171 6.80228 6.68618 6.69782C6.79064 6.59336 6.87349 6.46933 6.93 6.33283C6.9865 6.19633 7.01556 6.05003 7.01549 5.9023C7.01543 5.75457 6.98625 5.60829 6.92963 5.47184C6.87301 5.33539 6.79005 5.21143 6.6855 5.10706L5.6247 4.04626C5.5204 3.94137 5.39643 3.8581 5.25989 3.80121C5.12335 3.74432 4.97692 3.71493 4.82901 3.71472C4.68109 3.71452 4.53458 3.7435 4.39789 3.80001C4.26119 3.85652 4.13699 3.93945 4.03239 4.04404C3.9278 4.14864 3.84487 4.27284 3.78836 4.40954C3.73185 4.54624 3.70287 4.69274 3.70308 4.84066C3.70329 4.98858 3.73268 5.135 3.78957 5.27154C3.84646 5.40808 3.92974 5.53205 4.03462 5.63635L5.09541 6.69715Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                        </svg>\r\n                                    </span>\r\n                                    <span");
			base.WriteLiteral(" class=\"svg-icon theme-dark-show svg-icon-2\"");
			base.WriteLiteral(">\r\n                                        <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                                            <path");
			base.WriteLiteral(" d=\"M19.0647 5.43757C19.3421 5.43757 19.567 5.21271 19.567 4.93534C19.567 4.65796 19.3421 4.43311 19.0647 4.43311C18.7874 4.43311 18.5625 4.65796 18.5625 4.93534C18.5625 5.21271 18.7874 5.43757 19.0647 5.43757Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M20.0692 9.48884C20.3466 9.48884 20.5714 9.26398 20.5714 8.98661C20.5714 8.70923 20.3466 8.48438 20.0692 8.48438C19.7918 8.48438 19.567 8.70923 19.567 8.98661C19.567 9.26398 19.7918 9.48884 20.0692 9.48884Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M12.0335 20.5714C15.6943 20.5714 18.9426 18.2053 20.1168 14.7338C20.1884 14.5225 20.1114 14.289 19.9284 14.161C19.746 14.034 19.5003 14.0418 19.3257 14.1821C18.2432 15.0546 16.9371 15.5156 15.5491 15.5156C12.2257 15.5156 9.48884 12.8122 9.48884 9.48886C9.48884 7.41079 10.5773 5.47137 12.3449 4.35752C12.5342 4.23832 12.6 4.00733 12.5377 3.79251C12.4759 3.57768 12.2571 3.42859 12.0335 3.42859C7.32556 3.42859 3.42857 7.29209 3.42857 12C3.42857 16.7079 7.32556 20.5714 12.0335 20.5714Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                            <path");
			base.WriteLiteral(" d=\"M13.0379 7.47998C13.8688 7.47998 14.5446 8.15585 14.5446 8.98668C14.5446 9.26428 14.7693 9.48891 15.0469 9.48891C15.3245 9.48891 15.5491 9.26428 15.5491 8.98668C15.5491 8.15585 16.225 7.47998 17.0558 7.47998C17.3334 7.47998 17.558 7.25535 17.558 6.97775C17.558 6.70015 17.3334 6.47552 17.0558 6.47552C16.225 6.47552 15.5491 5.76616 15.5491 4.93534C15.5491 4.65774 15.3245 4.43311 15.0469 4.43311C14.7693 4.43311 14.5446 4.65774 14.5446 4.93534C14.5446 5.76616 13.8688 6.47552 13.0379 6.47552C12.7603 6.47552 12.5357 6.70015 12.5357 6.97775C12.5357 7.25535 12.7603 7.47998 13.0379 7.47998Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                        </svg>\r\n                                    </span>\r\n                                </a>\r\n                                <div");
			base.WriteLiteral(" class=\"menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-title-gray-700 menu-icon-muted menu-active-bg menu-state-color fw-semibold py-4 fs-base w-175px\"");
			base.WriteLiteral(" data-kt-menu=\"true\"");
			base.WriteLiteral(" data-kt-element=\"theme-mode-menu\"");
			base.WriteLiteral(">\r\n                                    <div");
			base.WriteLiteral(" class=\"menu-item px-3 my-0\"");
			base.WriteLiteral(">\r\n                                        <a");
			base.WriteLiteral(" href=\"#\"");
			base.WriteLiteral(" class=\"menu-link px-3 py-2\"");
			base.WriteLiteral(" data-kt-element=\"mode\"");
			base.WriteLiteral(" data-kt-value=\"light\"");
			base.WriteLiteral(">\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-icon\"");
			base.WriteLiteral(" data-kt-element=\"icon\"");
			base.WriteLiteral(">\r\n                                                <span");
			base.WriteLiteral(" class=\"svg-icon svg-icon-3\"");
			base.WriteLiteral(">\r\n                                                    <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                                                        <path");
			base.WriteLiteral(" d=\"M11.9905 5.62598C10.7293 5.62574 9.49646 5.9995 8.44775 6.69997C7.39903 7.40045 6.58159 8.39619 6.09881 9.56126C5.61603 10.7263 5.48958 12.0084 5.73547 13.2453C5.98135 14.4823 6.58852 15.6185 7.48019 16.5104C8.37186 17.4022 9.50798 18.0096 10.7449 18.2557C11.9818 18.5019 13.2639 18.3757 14.429 17.8931C15.5942 17.4106 16.5901 16.5933 17.2908 15.5448C17.9915 14.4962 18.3655 13.2634 18.3655 12.0023C18.3637 10.3119 17.6916 8.69129 16.4964 7.49593C15.3013 6.30056 13.6808 5.62806 11.9905 5.62598Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M22.1258 10.8771H20.627C20.3286 10.8771 20.0424 10.9956 19.8314 11.2066C19.6204 11.4176 19.5018 11.7038 19.5018 12.0023C19.5018 12.3007 19.6204 12.5869 19.8314 12.7979C20.0424 13.0089 20.3286 13.1274 20.627 13.1274H22.1258C22.4242 13.1274 22.7104 13.0089 22.9214 12.7979C23.1324 12.5869 23.2509 12.3007 23.2509 12.0023C23.2509 11.7038 23.1324 11.4176 22.9214 11.2066C22.7104 10.9956 22.4242 10.8771 22.1258 10.8771Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M11.9905 19.4995C11.6923 19.5 11.4064 19.6187 11.1956 19.8296C10.9848 20.0405 10.8663 20.3265 10.866 20.6247V22.1249C10.866 22.4231 10.9845 22.7091 11.1953 22.9199C11.4062 23.1308 11.6922 23.2492 11.9904 23.2492C12.2886 23.2492 12.5746 23.1308 12.7854 22.9199C12.9963 22.7091 13.1147 22.4231 13.1147 22.1249V20.6247C13.1145 20.3265 12.996 20.0406 12.7853 19.8296C12.5745 19.6187 12.2887 19.5 11.9905 19.4995Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M4.49743 12.0023C4.49718 11.704 4.37865 11.4181 4.16785 11.2072C3.95705 10.9962 3.67119 10.8775 3.37298 10.8771H1.87445C1.57603 10.8771 1.28984 10.9956 1.07883 11.2066C0.867812 11.4176 0.749266 11.7038 0.749266 12.0023C0.749266 12.3007 0.867812 12.5869 1.07883 12.7979C1.28984 13.0089 1.57603 13.1274 1.87445 13.1274H3.37299C3.6712 13.127 3.95706 13.0083 4.16785 12.7973C4.37865 12.5864 4.49718 12.3005 4.49743 12.0023Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M11.9905 4.50058C12.2887 4.50012 12.5745 4.38141 12.7853 4.17048C12.9961 3.95954 13.1147 3.67361 13.1149 3.3754V1.87521C13.1149 1.57701 12.9965 1.29103 12.7856 1.08017C12.5748 0.869313 12.2888 0.750854 11.9906 0.750854C11.6924 0.750854 11.4064 0.869313 11.1955 1.08017C10.9847 1.29103 10.8662 1.57701 10.8662 1.87521V3.3754C10.8664 3.67359 10.9849 3.95952 11.1957 4.17046C11.4065 4.3814 11.6923 4.50012 11.9905 4.50058Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M18.8857 6.6972L19.9465 5.63642C20.0512 5.53209 20.1343 5.40813 20.1911 5.27163C20.2479 5.13513 20.2772 4.98877 20.2774 4.84093C20.2775 4.69309 20.2485 4.54667 20.192 4.41006C20.1355 4.27344 20.0526 4.14932 19.948 4.04478C19.8435 3.94024 19.7194 3.85734 19.5828 3.80083C19.4462 3.74432 19.2997 3.71531 19.1519 3.71545C19.0041 3.7156 18.8577 3.7449 18.7212 3.80167C18.5847 3.85845 18.4607 3.94159 18.3564 4.04633L17.2956 5.10714C17.1909 5.21147 17.1077 5.33543 17.0509 5.47194C16.9942 5.60844 16.9649 5.7548 16.9647 5.90264C16.9646 6.05048 16.9936 6.19689 17.0501 6.33351C17.1066 6.47012 17.1895 6.59425 17.294 6.69878C17.3986 6.80332 17.5227 6.88621 17.6593 6.94272C17.7959 6.99923 17.9424 7.02824 18.0902 7.02809C18.238 7.02795 18.3844 6.99865 18.5209 6.94187C18.6574 6.88509 18.7814 6.80195 18.8857 6.6972Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M18.8855 17.3073C18.7812 17.2026 18.6572 17.1195 18.5207 17.0627C18.3843 17.006 18.2379 16.9767 18.0901 16.9766C17.9423 16.9764 17.7959 17.0055 17.6593 17.062C17.5227 17.1185 17.3986 17.2014 17.2941 17.3059C17.1895 17.4104 17.1067 17.5345 17.0501 17.6711C16.9936 17.8077 16.9646 17.9541 16.9648 18.1019C16.9649 18.2497 16.9942 18.3961 17.0509 18.5326C17.1077 18.6691 17.1908 18.793 17.2955 18.8974L18.3563 19.9582C18.4606 20.0629 18.5846 20.146 18.721 20.2027C18.8575 20.2595 19.0039 20.2887 19.1517 20.2889C19.2995 20.289 19.4459 20.26 19.5825 20.2035C19.7191 20.147 19.8432 20.0641 19.9477 19.9595C20.0523 19.855 20.1351 19.7309 20.1916 19.5943C20.2482 19.4577 20.2772 19.3113 20.277 19.1635C20.2769 19.0157 20.2476 18.8694 20.1909 18.7329C20.1341 18.5964 20.051 18.4724 19.9463 18.3681L18.8855 17.3073Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M5.09528 17.3072L4.0345 18.368C3.92972 18.4723 3.84655 18.5963 3.78974 18.7328C3.73294 18.8693 3.70362 19.0156 3.70346 19.1635C3.7033 19.3114 3.7323 19.4578 3.78881 19.5944C3.84532 19.7311 3.92822 19.8552 4.03277 19.9598C4.13732 20.0643 4.26147 20.1472 4.3981 20.2037C4.53473 20.2602 4.68117 20.2892 4.82902 20.2891C4.97688 20.2889 5.12325 20.2596 5.25976 20.2028C5.39627 20.146 5.52024 20.0628 5.62456 19.958L6.68536 18.8973C6.79007 18.7929 6.87318 18.6689 6.92993 18.5325C6.98667 18.396 7.01595 18.2496 7.01608 18.1018C7.01621 17.954 6.98719 17.8076 6.93068 17.671C6.87417 17.5344 6.79129 17.4103 6.68676 17.3058C6.58224 17.2012 6.45813 17.1183 6.32153 17.0618C6.18494 17.0053 6.03855 16.9763 5.89073 16.9764C5.74291 16.9766 5.59657 17.0058 5.46007 17.0626C5.32358 17.1193 5.19962 17.2024 5.09528 17.3072Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M5.09541 6.69715C5.19979 6.8017 5.32374 6.88466 5.4602 6.94128C5.59665 6.9979 5.74292 7.02708 5.89065 7.02714C6.03839 7.0272 6.18469 6.99815 6.32119 6.94164C6.45769 6.88514 6.58171 6.80228 6.68618 6.69782C6.79064 6.59336 6.87349 6.46933 6.93 6.33283C6.9865 6.19633 7.01556 6.05003 7.01549 5.9023C7.01543 5.75457 6.98625 5.60829 6.92963 5.47184C6.87301 5.33539 6.79005 5.21143 6.6855 5.10706L5.6247 4.04626C5.5204 3.94137 5.39643 3.8581 5.25989 3.80121C5.12335 3.74432 4.97692 3.71493 4.82901 3.71472C4.68109 3.71452 4.53458 3.7435 4.39789 3.80001C4.26119 3.85652 4.13699 3.93945 4.03239 4.04404C3.9278 4.14864 3.84487 4.27284 3.78836 4.40954C3.73185 4.54624 3.70287 4.69274 3.70308 4.84066C3.70329 4.98858 3.73268 5.135 3.78957 5.27154C3.84646 5.40808 3.92974 5.53205 4.03462 5.63635L5.09541 6.69715Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                    </svg>\r\n                                                </span>\r\n                                            </span>\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-title\"");
			base.WriteLiteral(">Light</span>\r\n                                        </a>\r\n                                    </div>\r\n                                    <div");
			base.WriteLiteral(" class=\"menu-item px-3 my-0\"");
			base.WriteLiteral(">\r\n                                        <a");
			base.WriteLiteral(" href=\"#\"");
			base.WriteLiteral(" class=\"menu-link px-3 py-2\"");
			base.WriteLiteral(" data-kt-element=\"mode\"");
			base.WriteLiteral(" data-kt-value=\"dark\"");
			base.WriteLiteral(">\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-icon\"");
			base.WriteLiteral(" data-kt-element=\"icon\"");
			base.WriteLiteral(">\r\n                                                <span");
			base.WriteLiteral(" class=\"svg-icon svg-icon-3\"");
			base.WriteLiteral(">\r\n                                                    <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                                                        <path");
			base.WriteLiteral(" d=\"M19.0647 5.43757C19.3421 5.43757 19.567 5.21271 19.567 4.93534C19.567 4.65796 19.3421 4.43311 19.0647 4.43311C18.7874 4.43311 18.5625 4.65796 18.5625 4.93534C18.5625 5.21271 18.7874 5.43757 19.0647 5.43757Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M20.0692 9.48884C20.3466 9.48884 20.5714 9.26398 20.5714 8.98661C20.5714 8.70923 20.3466 8.48438 20.0692 8.48438C19.7918 8.48438 19.567 8.70923 19.567 8.98661C19.567 9.26398 19.7918 9.48884 20.0692 9.48884Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M12.0335 20.5714C15.6943 20.5714 18.9426 18.2053 20.1168 14.7338C20.1884 14.5225 20.1114 14.289 19.9284 14.161C19.746 14.034 19.5003 14.0418 19.3257 14.1821C18.2432 15.0546 16.9371 15.5156 15.5491 15.5156C12.2257 15.5156 9.48884 12.8122 9.48884 9.48886C9.48884 7.41079 10.5773 5.47137 12.3449 4.35752C12.5342 4.23832 12.6 4.00733 12.5377 3.79251C12.4759 3.57768 12.2571 3.42859 12.0335 3.42859C7.32556 3.42859 3.42857 7.29209 3.42857 12C3.42857 16.7079 7.32556 20.5714 12.0335 20.5714Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                        <path");
			base.WriteLiteral(" d=\"M13.0379 7.47998C13.8688 7.47998 14.5446 8.15585 14.5446 8.98668C14.5446 9.26428 14.7693 9.48891 15.0469 9.48891C15.3245 9.48891 15.5491 9.26428 15.5491 8.98668C15.5491 8.15585 16.225 7.47998 17.0558 7.47998C17.3334 7.47998 17.558 7.25535 17.558 6.97775C17.558 6.70015 17.3334 6.47552 17.0558 6.47552C16.225 6.47552 15.5491 5.76616 15.5491 4.93534C15.5491 4.65774 15.3245 4.43311 15.0469 4.43311C14.7693 4.43311 14.5446 4.65774 14.5446 4.93534C14.5446 5.76616 13.8688 6.47552 13.0379 6.47552C12.7603 6.47552 12.5357 6.70015 12.5357 6.97775C12.5357 7.25535 12.7603 7.47998 13.0379 7.47998Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                    </svg>\r\n                                                </span>\r\n                                            </span>\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-title\"");
			base.WriteLiteral(">Dark</span>\r\n                                        </a>\r\n                                    </div>\r\n                                    <div");
			base.WriteLiteral(" class=\"menu-item px-3 my-0\"");
			base.WriteLiteral(">\r\n                                        <a");
			base.WriteLiteral(" href=\"#\"");
			base.WriteLiteral(" class=\"menu-link px-3 py-2\"");
			base.WriteLiteral(" data-kt-element=\"mode\"");
			base.WriteLiteral(" data-kt-value=\"system\"");
			base.WriteLiteral(">\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-icon\"");
			base.WriteLiteral(" data-kt-element=\"icon\"");
			base.WriteLiteral(">\r\n                                                <span");
			base.WriteLiteral(" class=\"svg-icon svg-icon-3\"");
			base.WriteLiteral(">\r\n                                                    <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                                                        <path");
			base.WriteLiteral(" fill-rule=\"evenodd\"");
			base.WriteLiteral(" clip-rule=\"evenodd\"");
			base.WriteLiteral(" d=\"M1.34375 3.9463V15.2178C1.34375 16.119 2.08105 16.8563 2.98219 16.8563H8.65093V19.4594H6.15702C5.38853 19.4594 4.75981 19.9617 4.75981 20.5757V21.6921H19.2403V20.5757C19.2403 19.9617 18.6116 19.4594 17.8431 19.4594H15.3492V16.8563H21.0179C21.919 16.8563 22.6562 16.119 22.6562 15.2178V3.9463C22.6562 3.04516 21.9189 2.30786 21.0179 2.30786H2.98219C2.08105 2.30786 1.34375 3.04516 1.34375 3.9463ZM12.9034 9.9016C13.241 9.98792 13.5597 10.1216 13.852 10.2949L15.0393 9.4353L15.9893 10.3853L15.1297 11.5727C15.303 11.865 15.4366 12.1837 15.523 12.5212L16.97 12.7528V13.4089H13.9851C13.9766 12.3198 13.0912 11.4394 12 11.4394C10.9089 11.4394 10.0235 12.3198 10.015 13.4089H7.03006V12.7528L8.47712 12.5211C8.56345 12.1836 8.69703 11.8649 8.87037 11.5727L8.0107 10.3853L8.96078 9.4353L10.148 10.2949C10.4404 10.1215 10.759 9.98788 11.0966 9.9016L11.3282 8.45467H12.6718L12.9034 9.9016ZM16.1353 7.93758C15.6779 7.93758 15.3071 7.56681 15.3071 7.1094C15.3071 6.652 15.6779 6.28122 16.1353 6.28122C16.5926 6.28122 16.9634 6.652 16.9634 7.1094C16.9634 7.56681 16.5926 7.93758 16.1353 7.93758ZM2.71385 14.0964V3.90518C2.71385 3.78023 2.81612 3.67796 2.94107 3.67796H21.0589C21.1839 3.67796 21.2861 3.78023 21.2861 3.90518V14.0964C15.0954 14.0964 8.90462 14.0964 2.71385 14.0964Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                                                    </svg>\r\n                                                </span>\r\n                                            </span>\r\n                                            <span");
			base.WriteLiteral(" class=\"menu-title\"");
			base.WriteLiteral(">System</span>\r\n                                        </a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
			string path = string.Empty;
			if (this.Model.PathDic.Any<Tuple<string, string>>() && this.Model.PathDic.LastOrDefault<Tuple<string, string>>() != null)
			{
				Tuple<string, string> tuple = this.Model.PathDic.LastOrDefault<Tuple<string, string>>();
				path = ((tuple != null) ? tuple.Item1 : null);
			}
			base.WriteLiteral("\r\n                <input");
			base.WriteLiteral(" type=\"hidden\"");
			base.WriteLiteral(" id=\"lastPathForUpload\"");
			base.WriteAttribute("value", " value=\"", "\"", new Tuple<string, object, bool>[]
			{
				Tuple.Create<string, object, bool>("", path, false)
			});
			base.WriteLiteral(" />\r\n");
			if (this.Model.IsAuth)
			{
				base.WriteLiteral("                    <div");
				base.WriteLiteral(" class=\"content d-flex flex-column flex-column-fluid\"");
				base.WriteLiteral(" id=\"kt_content\"");
				base.WriteLiteral(">\r\n                        <div");
				base.WriteLiteral(" class=\"container-fluid\"");
				base.WriteLiteral(" id=\"kt_content_container\"");
				base.WriteLiteral(">\r\n                            <div");
				base.WriteLiteral(" class=\"card card-flush\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"card-header pt-8\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"card-title\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"d-flex align-items-center position-relative my-1\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1 position-absolute ms-6\"");
				base.WriteLiteral(">\r\n                                                <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                    <rect");
				base.WriteLiteral(" opacity=\"0.5\"");
				base.WriteLiteral(" x=\"17.0365\"");
				base.WriteLiteral(" y=\"15.1223\"");
				base.WriteLiteral(" width=\"8.15546\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(45 17.0365 15.1223)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                    <path");
				base.WriteLiteral(" d=\"M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C19 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4667 5 11 5Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                </svg>\r\n                                            </span>\r\n                                            <input");
				base.WriteLiteral(" type=\"text\"");
				base.WriteLiteral(" data-kt-filemanager-table-filter=\"search\"");
				base.WriteLiteral(" class=\"form-control form-control-solid w-250px ps-15\"");
				base.WriteLiteral(" placeholder=\"Search Files & Folders\"");
				base.WriteLiteral(" />\r\n                                        </div>\r\n                                    </div>\r\n                                    <div");
				base.WriteLiteral(" class=\"card-toolbar\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"d-flex justify-content-end\"");
				base.WriteLiteral(" data-kt-filemanager-table-toolbar=\"base\"");
				base.WriteLiteral(">\r\n");
				if (this.Model.CanCreateNewFolder)
				{
					base.WriteLiteral("                                                <button");
					base.WriteLiteral(" type=\"button\"");
					base.WriteLiteral(" class=\"btn btn-sm btn-light-primary\"");
					base.WriteLiteral(" id=\"kt_file_manager_new_folder\"");
					base.WriteLiteral(">\r\n                                                    <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-2\"");
					base.WriteLiteral(">\r\n                                                        <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                            <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                            <path");
					base.WriteLiteral(" d=\"M10.4 3.60001L12 6H21C21.6 6 22 6.4 22 7V19C22 19.6 21.6 20 21 20H3C2.4 20 2 19.6 2 19V4C2 3.4 2.4 3 3 3H9.2C9.7 3 10.2 3.20001 10.4 3.60001ZM16 12H13V9C13 8.4 12.6 8 12 8C11.4 8 11 8.4 11 9V12H8C7.4 12 7 12.4 7 13C7 13.6 7.4 14 8 14H11V17C11 17.6 11.4 18 12 18C12.6 18 13 17.6 13 17V14H16C16.6 14 17 13.6 17 13C17 12.4 16.6 12 16 12Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                            <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M11 14H8C7.4 14 7 13.6 7 13C7 12.4 7.4 12 8 12H11V14ZM16 12H13V14H16C16.6 14 17 13.6 17 13C17 12.4 16.6 12 16 12Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                    New Folder\r\n                                                </button>\r\n");
				}
				else
				{
					base.WriteLiteral("                                                <input");
					base.WriteLiteral(" type=\"hidden\"");
					base.WriteLiteral(" id=\"kt_file_manager_new_folder\"");
					base.WriteLiteral(" />\r\n");
				}
				base.WriteLiteral("\r\n");
				if (this.Model.CanUploadFile)
				{
					base.WriteLiteral("                                                <button");
					base.WriteLiteral(" type=\"button\"");
					base.WriteLiteral(" class=\"btn btn-sm btn-primary ms-3\"");
					base.WriteLiteral(" data-bs-toggle=\"modal\"");
					base.WriteLiteral(" data-bs-target=\"#kt_modal_upload\"");
					base.WriteLiteral(">\r\n                                                    <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-2\"");
					base.WriteLiteral(">\r\n                                                        <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                            <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                            <path");
					base.WriteLiteral(" d=\"M10.4 3.60001L12 6H21C21.6 6 22 6.4 22 7V19C22 19.6 21.6 20 21 20H3C2.4 20 2 19.6 2 19V4C2 3.4 2.4 3 3 3H9.20001C9.70001 3 10.2 3.20001 10.4 3.60001ZM16 11.6L12.7 8.29999C12.3 7.89999 11.7 7.89999 11.3 8.29999L8 11.6H11V17C11 17.6 11.4 18 12 18C12.6 18 13 17.6 13 17V11.6H16Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                            <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M11 11.6V17C11 17.6 11.4 18 12 18C12.6 18 13 17.6 13 17V11.6H11Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                    Upload Files\r\n                                                </button>\r\n");
				}
				base.WriteLiteral("                                        </div>\r\n                                        <div");
				base.WriteLiteral(" class=\"d-flex justify-content-end align-items-center d-none\"");
				base.WriteLiteral(" data-kt-filemanager-table-toolbar=\"selected\"");
				base.WriteLiteral(">\r\n                                            <div");
				base.WriteLiteral(" class=\"fw-bold me-5\"");
				base.WriteLiteral(">\r\n                                                <span");
				base.WriteLiteral(" class=\"me-2\"");
				base.WriteLiteral(" data-kt-filemanager-table-select=\"selected_count\"");
				base.WriteLiteral("></span>Selected\r\n                                            </div>\r\n");
				if (this.Model.CanDelete)
				{
					base.WriteLiteral("                                                <button");
					base.WriteLiteral(" type=\"button\"");
					base.WriteLiteral(" class=\"btn btn-sm btn-danger\"");
					base.WriteLiteral(" data-kt-filemanager-table-select=\"delete_selected\"");
					base.WriteLiteral(">Delete Selected</button>\r\n");
				}
				else
				{
					base.WriteLiteral("                                                <input");
					base.WriteLiteral(" type=\"hidden\"");
					base.WriteLiteral(" data-kt-filemanager-table-select=\"delete_selected\"");
					base.WriteLiteral(" />\r\n");
				}
				base.WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div");
				base.WriteLiteral(" class=\"card-body\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"d-flex flex-stack\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"badge badge-lg badge-light-primary\"");
				base.WriteLiteral(">\r\n                                            <div");
				base.WriteLiteral(" class=\"d-flex align-items-center flex-wrap\"");
				base.WriteLiteral(">\r\n");
				foreach (Tuple<string, string> item in this.Model.PathDic)
				{
					base.WriteLiteral("                                                    <a");
					base.WriteAttribute("href", " href=\"", "\"", new Tuple<string, object, bool>[]
					{
						Tuple.Create<string, object, bool>("", item.Item1, false),
						Tuple.Create<string, object, bool>("", "/", true)
					});
					base.WriteLiteral(">");
					base.Write(item.Item2);
					base.WriteLiteral("</a>\r\n");
					if (!this.Model.PathDic.LastOrDefault<Tuple<string, string>>().Item1.Equals(item.Item1))
					{
						base.WriteLiteral("                                                        <span");
						base.WriteLiteral(" class=\"svg-icon svg-icon-2 svg-icon-primary mx-1\"");
						base.WriteLiteral(">\r\n                                                            <svg");
						base.WriteLiteral(" width=\"24\"");
						base.WriteLiteral(" height=\"24\"");
						base.WriteLiteral(" viewBox=\"0 0 24 24\"");
						base.WriteLiteral(" fill=\"none\"");
						base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
						base.WriteLiteral(">\r\n                                                                <path");
						base.WriteLiteral(" d=\"M12.6343 12.5657L8.45001 16.75C8.0358 17.1642 8.0358 17.8358 8.45001 18.25C8.86423 18.6642 9.5358 18.6642 9.95001 18.25L15.4929 12.7071C15.8834 12.3166 15.8834 11.6834 15.4929 11.2929L9.95001 5.75C9.5358 5.33579 8.86423 5.33579 8.45001 5.75C8.0358 6.16421 8.0358 6.83579 8.45001 7.25L12.6343 11.4343C12.9467 11.7467 12.9467 12.2533 12.6343 12.5657Z\"");
						base.WriteLiteral(" fill=\"currentColor\"");
						base.WriteLiteral(" />\r\n                                                            </svg>\r\n                                                        </span>\r\n");
					}
				}
				base.WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div");
				base.WriteLiteral(" class=\"badge badge-lg badge-primary\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" id=\"kt_file_manager_items_counter\"");
				base.WriteLiteral(">0 items</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <table");
				base.WriteLiteral(" id=\"kt_file_manager_list\"");
				base.WriteLiteral(" data-kt-filemanager-table=\"folders\"");
				base.WriteLiteral(" class=\"table align-middle table-row-dashed fs-6 gy-5\"");
				base.WriteLiteral(">\r\n                                        <thead>\r\n                                            <tr");
				base.WriteLiteral(" class=\"text-start text-gray-400 fw-bold fs-7 text-uppercase gs-0\"");
				base.WriteLiteral(">\r\n                                                <th");
				base.WriteLiteral(" class=\"w-10px pe-2\"");
				base.WriteLiteral(">\r\n                                                    <div");
				base.WriteLiteral(" class=\"form-check form-check-sm form-check-custom form-check-solid me-3\"");
				base.WriteLiteral(">\r\n                                                        <input");
				base.WriteLiteral(" class=\"form-check-input\"");
				base.WriteLiteral(" type=\"checkbox\"");
				base.WriteLiteral(" data-kt-check=\"true\"");
				base.WriteLiteral(" data-kt-check-target=\"#kt_file_manager_list .form-check-input\"");
				base.WriteLiteral(" value=\"1\"");
				base.WriteLiteral(" />\r\n                                                    </div>\r\n                                                </th>\r\n                                                <th");
				base.WriteLiteral(" class=\"min-w-250px\"");
				base.WriteLiteral(">Name</th>\r\n                                                <th");
				base.WriteLiteral(" class=\"min-w-10px\"");
				base.WriteLiteral(">Size</th>\r\n                                                <th");
				base.WriteLiteral(" class=\"min-w-125px\"");
				base.WriteLiteral(">Last Modified</th>\r\n                                                <th");
				base.WriteLiteral(" class=\"w-125px\"");
				base.WriteLiteral("></th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody");
				base.WriteLiteral(" class=\"fw-semibold text-gray-600\"");
				base.WriteLiteral(">\r\n");
				foreach (FileInfoDetail item2 in this.Model.FileInfoDetailList)
				{
					base.WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        <div");
					base.WriteLiteral(" class=\"form-check form-check-sm form-check-custom form-check-solid\"");
					base.WriteLiteral(">\r\n                                                            <input");
					base.WriteLiteral(" class=\"form-check-input\"");
					base.WriteLiteral(" type=\"checkbox\"");
					base.WriteLiteral(" data-file-name=\"");
					base.Write(item2.Name);
					base.WriteLiteral("\"");
					base.WriteLiteral(" />\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td");
					base.WriteLiteral(" data-order=\"nekibuki\"");
					base.WriteLiteral(">\r\n                                                        <div");
					base.WriteLiteral(" class=\"d-flex align-items-center\"");
					base.WriteLiteral(">\r\n                                                            <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-2x svg-icon-primary me-4\"");
					base.WriteLiteral(">\r\n");
					if (item2.IsFolder)
					{
						base.WriteLiteral("                                                                    <svg");
						base.WriteLiteral(" width=\"24\"");
						base.WriteLiteral(" height=\"24\"");
						base.WriteLiteral(" viewBox=\"0 0 24 24\"");
						base.WriteLiteral(" fill=\"none\"");
						base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
						base.WriteLiteral("><path");
						base.WriteLiteral(" opacity=\"0.3\"");
						base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
						base.WriteLiteral(" fill=\"currentColor\"");
						base.WriteLiteral(" /><path");
						base.WriteLiteral(" d=\"M9.2 3H3C2.4 3 2 3.4 2 4V19C2 19.6 2.4 20 3 20H21C21.6 20 22 19.6 22 19V7C22 6.4 21.6 6 21 6H12L10.4 3.60001C10.2 3.20001 9.7 3 9.2 3Z\"");
						base.WriteLiteral(" fill=\"currentColor\"");
						base.WriteLiteral(" /></svg>\r\n");
					}
					else
					{
						base.WriteLiteral("                                                                    <svg");
						base.WriteLiteral(" width=\"24\"");
						base.WriteLiteral(" height=\"24\"");
						base.WriteLiteral(" viewBox=\"0 0 24 24\"");
						base.WriteLiteral(" fill=\"none\"");
						base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
						base.WriteLiteral("><path");
						base.WriteLiteral(" opacity=\"0.3\"");
						base.WriteLiteral(" d=\"M19 22H5C4.4 22 4 21.6 4 21V3C4 2.4 4.4 2 5 2H14L20 8V21C20 21.6 19.6 22 19 22Z\"");
						base.WriteLiteral(" fill=\"currentColor\"");
						base.WriteLiteral("></path><path");
						base.WriteLiteral(" d=\"M15 8H20L14 2V7C14 7.6 14.4 8 15 8Z\"");
						base.WriteLiteral(" fill=\"currentColor\"");
						base.WriteLiteral("></path></svg>\r\n");
					}
					base.WriteLiteral("                                                            </span>\r\n                                                            <a");
					base.WriteAttribute("href", " href=\"", "\"", new Tuple<string, object, bool>[]
					{
						Tuple.Create<string, object, bool>("", item2.Path, false)
					});
					base.WriteLiteral(" class=\"text-gray-800 text-hover-primary\"");
					base.WriteLiteral(" ");
					base.Write((!item2.IsFolder) ? "target='_blank'" : string.Empty);
					base.WriteLiteral(">");
					base.Write(item2.Name);
					base.WriteLiteral("</a>\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td>");
					base.Write(item2.Length);
					base.WriteLiteral("</td>\r\n                                                    <td>");
					base.Write(item2.LastWriteTime);
					base.WriteLiteral("</td>\r\n                                                    <td");
					base.WriteLiteral(" class=\"text-end\"");
					base.WriteLiteral(" data-kt-filemanager-table=\"action_dropdown\"");
					base.WriteLiteral(">\r\n                                                        <div");
					base.WriteLiteral(" class=\"d-flex justify-content-end\"");
					base.WriteLiteral(">\r\n                                                            <div");
					base.WriteLiteral(" class=\"ms-2\"");
					base.WriteLiteral(" data-kt-filemanger-table=\"copy_link\"");
					base.WriteLiteral(">\r\n                                                                <button");
					base.WriteLiteral(" type=\"button\"");
					base.WriteLiteral(" class=\"btn btn-sm btn-icon btn-light btn-active-light-primary\"");
					base.WriteLiteral(" data-kt-menu-trigger=\"click\"");
					base.WriteLiteral(" data-kt-menu-placement=\"bottom-end\"");
					base.WriteLiteral(">\r\n                                                                    <!--begin::Svg Icon | path: icons/duotune/coding/cod007.svg-->\r\n                                                                    <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-5 m-0\"");
					base.WriteLiteral(">\r\n                                                                        <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                                            <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M18.4 5.59998C18.7766 5.9772 18.9881 6.48846 18.9881 7.02148C18.9881 7.55451 18.7766 8.06577 18.4 8.44299L14.843 12C14.466 12.377 13.9547 12.5887 13.4215 12.5887C12.8883 12.5887 12.377 12.377 12 12C11.623 11.623 11.4112 11.1117 11.4112 10.5785C11.4112 10.0453 11.623 9.53399 12 9.15698L15.553 5.604C15.9302 5.22741 16.4415 5.01587 16.9745 5.01587C17.5075 5.01587 18.0188 5.22741 18.396 5.604L18.4 5.59998ZM20.528 3.47205C20.0614 3.00535 19.5074 2.63503 18.8977 2.38245C18.288 2.12987 17.6344 1.99988 16.9745 1.99988C16.3145 1.99988 15.661 2.12987 15.0513 2.38245C14.4416 2.63503 13.8876 3.00535 13.421 3.47205L9.86801 7.02502C9.40136 7.49168 9.03118 8.04568 8.77863 8.6554C8.52608 9.26511 8.39609 9.91855 8.39609 10.5785C8.39609 11.2384 8.52608 11.8919 8.77863 12.5016C9.03118 13.1113 9.40136 13.6653 9.86801 14.132C10.3347 14.5986 10.8886 14.9688 11.4984 15.2213C12.1081 15.4739 12.7616 15.6039 13.4215 15.6039C14.0815 15.6039 14.7349 15.4739 15.3446 15.2213C15.9543 14.9688 16.5084 14.5986 16.975 14.132L20.528 10.579C20.9947 10.1124 21.3649 9.55844 21.6175 8.94873C21.8701 8.33902 22.0001 7.68547 22.0001 7.02551C22.0001 6.36555 21.8701 5.71201 21.6175 5.10229C21.3649 4.49258 20.9947 3.93867 20.528 3.47205Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                            <path");
					base.WriteLiteral(" d=\"M14.132 9.86804C13.6421 9.37931 13.0561 8.99749 12.411 8.74695L12 9.15698C11.6234 9.53421 11.4119 10.0455 11.4119 10.5785C11.4119 11.1115 11.6234 11.6228 12 12C12.3766 12.3772 12.5881 12.8885 12.5881 13.4215C12.5881 13.9545 12.3766 14.4658 12 14.843L8.44699 18.396C8.06999 18.773 7.55868 18.9849 7.02551 18.9849C6.49235 18.9849 5.98101 18.773 5.604 18.396C5.227 18.019 5.0152 17.5077 5.0152 16.9745C5.0152 16.4413 5.227 15.93 5.604 15.553L8.74701 12.411C8.28705 11.233 8.28705 9.92498 8.74701 8.74695C8.10159 8.99737 7.5152 9.37919 7.02499 9.86804L3.47198 13.421C2.52954 14.3635 2.00009 15.6417 2.00009 16.9745C2.00009 18.3073 2.52957 19.5855 3.47202 20.528C4.41446 21.4704 5.69269 21.9999 7.02551 21.9999C8.35833 21.9999 9.63656 21.4704 10.579 20.528L14.132 16.975C14.5987 16.5084 14.9689 15.9544 15.2215 15.3447C15.4741 14.735 15.6041 14.0815 15.6041 13.4215C15.6041 12.7615 15.4741 12.108 15.2215 11.4983C14.9689 10.8886 14.5987 10.3347 14.132 9.86804Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                        </svg>\r\n                                                                    </span>\r\n                                                                </button>\r\n                                                                <div");
					base.WriteLiteral(" class=\"menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-semibold fs-7 w-300px\"");
					base.WriteLiteral(" data-kt-menu=\"true\"");
					base.WriteLiteral(">\r\n                                                                    <div");
					base.WriteLiteral(" class=\"card card-flush\"");
					base.WriteLiteral(">\r\n                                                                        <div");
					base.WriteLiteral(" class=\"card-body p-5\"");
					base.WriteLiteral(">\r\n                                                                            <div");
					base.WriteLiteral(" class=\"d-flex\"");
					base.WriteLiteral(" data-kt-filemanger-table=\"copy_link_generator\"");
					base.WriteLiteral(">\r\n                                                                                <div");
					base.WriteLiteral(" class=\"me-5\"");
					base.WriteLiteral(" data-kt-indicator=\"on\"");
					base.WriteLiteral(">\r\n                                                                                    <span");
					base.WriteLiteral(" class=\"indicator-progress\"");
					base.WriteLiteral(">\r\n                                                                                        <span");
					base.WriteLiteral(" class=\"spinner-border spinner-border-sm align-middle ms-2\"");
					base.WriteLiteral("></span>\r\n                                                                                    </span>\r\n                                                                                </div>\r\n                                                                                <div");
					base.WriteLiteral(" class=\"fs-6 text-dark\"");
					base.WriteLiteral(">Generating Share Link...</div>\r\n                                                                            </div>\r\n                                                                            <div");
					base.WriteLiteral(" class=\"d-flex flex-column text-start d-none\"");
					base.WriteLiteral(" data-kt-filemanger-table=\"copy_link_result\"");
					base.WriteLiteral(">\r\n                                                                                <div");
					base.WriteLiteral(" class=\"d-flex mb-3\"");
					base.WriteLiteral(">\r\n                                                                                    <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-2 svg-icon-success me-3\"");
					base.WriteLiteral(">\r\n                                                                                        <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                                                            <path");
					base.WriteLiteral(" d=\"M9.89557 13.4982L7.79487 11.2651C7.26967 10.7068 6.38251 10.7068 5.85731 11.2651C5.37559 11.7772 5.37559 12.5757 5.85731 13.0878L9.74989 17.2257C10.1448 17.6455 10.8118 17.6455 11.2066 17.2257L18.1427 9.85252C18.6244 9.34044 18.6244 8.54191 18.1427 8.02984C17.6175 7.47154 16.7303 7.47154 16.2051 8.02984L11.061 13.4982C10.7451 13.834 10.2115 13.834 9.89557 13.4982Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                                        </svg>\r\n                                                                                    </span>\r\n                                                                                    <div");
					base.WriteLiteral(" class=\"fs-6 text-dark\"");
					base.WriteLiteral(">Share Link Generated</div>\r\n                                                                                </div>\r\n                                                                                <input");
					base.WriteLiteral(" type=\"text\"");
					base.WriteLiteral(" class=\"form-control form-control-sm\"");
					base.WriteLiteral(" value=\"\"");
					base.WriteLiteral(" data-file-name=\"");
					base.Write(item2.Name);
					base.WriteLiteral("\"");
					base.WriteLiteral(" />\r\n                                                                                <div");
					base.WriteLiteral(" class=\"text-muted fw-normal mt-2 fs-8 px-3\"");
					base.WriteLiteral(">\r\n                                                                                    Read only.\r\n                                                                                </div>\r\n                                                                            </div>\r\n                                                                        </div>\r\n                                                                    </div>\r\n                                                                </div>\r\n                                                            </div>\r\n                                                            <div");
					base.WriteLiteral(" class=\"ms-2\"");
					base.WriteLiteral(">\r\n                                                                <button");
					base.WriteLiteral(" type=\"button\"");
					base.WriteLiteral(" class=\"btn btn-sm btn-icon btn-light btn-active-light-primary me-2\"");
					base.WriteLiteral(" data-kt-menu-trigger=\"click\"");
					base.WriteLiteral(" data-kt-menu-placement=\"bottom-end\"");
					base.WriteLiteral(">\r\n                                                                    <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-5 m-0\"");
					base.WriteLiteral(">\r\n                                                                        <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                                            <rect");
					base.WriteLiteral(" x=\"10\"");
					base.WriteLiteral(" y=\"10\"");
					base.WriteLiteral(" width=\"4\"");
					base.WriteLiteral(" height=\"4\"");
					base.WriteLiteral(" rx=\"2\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                            <rect");
					base.WriteLiteral(" x=\"17\"");
					base.WriteLiteral(" y=\"10\"");
					base.WriteLiteral(" width=\"4\"");
					base.WriteLiteral(" height=\"4\"");
					base.WriteLiteral(" rx=\"2\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                            <rect");
					base.WriteLiteral(" x=\"3\"");
					base.WriteLiteral(" y=\"10\"");
					base.WriteLiteral(" width=\"4\"");
					base.WriteLiteral(" height=\"4\"");
					base.WriteLiteral(" rx=\"2\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                        </svg>\r\n                                                                    </span>\r\n                                                                </button>\r\n                                                                <div");
					base.WriteLiteral(" class=\"menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-semibold fs-7 w-150px py-4\"");
					base.WriteLiteral(" data-kt-menu=\"true\"");
					base.WriteLiteral(">\r\n");
					if (item2.IsFolder)
					{
						base.WriteLiteral("                                                                        <div");
						base.WriteLiteral(" class=\"menu-item px-3\"");
						base.WriteLiteral(">\r\n                                                                            <a");
						base.WriteAttribute("href", " href=\"", "\"", new Tuple<string, object, bool>[]
						{
							Tuple.Create<string, object, bool>("", "/BUrOF07TASaVd7qPuALBXVhnsDdAUiCx?isFolder=True&fileName=", true),
							Tuple.Create<string, object, bool>("", item2.Path, false)
						});
						base.WriteLiteral(" class=\"menu-link px-3\"");
						base.WriteLiteral(" target='_blank'");
						base.WriteLiteral(">Download Folder</a>\r\n                                                                        </div>\r\n");
					}
					else
					{
						base.WriteLiteral("                                                                        <div");
						base.WriteLiteral(" class=\"menu-item px-3\"");
						base.WriteLiteral(">\r\n                                                                            <a");
						base.WriteAttribute("href", " href=\"", "\"", new Tuple<string, object, bool>[]
						{
							Tuple.Create<string, object, bool>("", "/BUrOF07TASaVd7qPuALBXVhnsDdAUiCx?fileName=", true),
							Tuple.Create<string, object, bool>("", item2.Path, false)
						});
						base.WriteLiteral(" class=\"menu-link px-3\"");
						base.WriteLiteral(" target='_blank'");
						base.WriteLiteral(">Download File</a>\r\n                                                                        </div>\r\n");
					}
					base.WriteLiteral("\r\n");
					if (this.Model.CanMoveToFolder)
					{
						base.WriteLiteral("                                                                        <div");
						base.WriteLiteral(" class=\"menu-item px-3\"");
						base.WriteLiteral(">\r\n                                                                            <a");
						base.WriteLiteral(" href=\"javascript:;\"");
						base.WriteLiteral(" class=\"menu-link px-3\"");
						base.WriteLiteral(" data-kt-filemanager-table-filter=\"move_row\"");
						base.WriteLiteral(" data-kt-filemanager-table=\"moveToFolder\"");
						base.WriteLiteral(" data-file-name=\"");
						base.Write(item2.Name);
						base.WriteLiteral("\"");
						base.WriteLiteral(">Move to folder</a>\r\n                                                                        </div>\r\n");
					}
					base.WriteLiteral("\r\n");
					if (this.Model.CanRename)
					{
						base.WriteLiteral("                                                                        <div");
						base.WriteLiteral(" class=\"menu-item px-3\"");
						base.WriteLiteral(">\r\n                                                                            <a");
						base.WriteLiteral(" href=\"javascript:;\"");
						base.WriteLiteral(" class=\"menu-link px-3\"");
						base.WriteLiteral(" data-kt-filemanager-table=\"rename\"");
						base.WriteLiteral(">Rename</a>\r\n                                                                        </div>\r\n");
					}
					base.WriteLiteral("\r\n");
					if (this.Model.CanDelete)
					{
						base.WriteLiteral("                                                                        <div");
						base.WriteLiteral(" class=\"menu-item px-3\"");
						base.WriteLiteral(">\r\n                                                                            <a");
						base.WriteLiteral(" href=\"#\"");
						base.WriteLiteral(" class=\"menu-link text-danger px-3\"");
						base.WriteLiteral(" data-kt-filemanager-table-filter=\"delete_row\"");
						base.WriteLiteral(">Delete</a>\r\n                                                                        </div>\r\n");
					}
					base.WriteLiteral("                                                                </div>\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </td>\r\n                                                </tr>\r\n");
				}
				base.WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                            <table");
				base.WriteLiteral(" class=\"d-none\"");
				base.WriteLiteral(">\r\n                                <tr");
				base.WriteLiteral(" id=\"kt_file_manager_new_folder_row\"");
				base.WriteLiteral(" data-kt-filemanager-template=\"upload\"");
				base.WriteLiteral(">\r\n                                    <td></td>\r\n                                    <td");
				base.WriteLiteral(" id=\"kt_file_manager_add_folder_form\"");
				base.WriteLiteral(" class=\"fv-row\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"d-flex align-items-center\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-2x svg-icon-primary me-4\"");
				base.WriteLiteral(">\r\n                                                <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                    <path");
				base.WriteLiteral(" opacity=\"0.3\"");
				base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                    <path");
				base.WriteLiteral(" d=\"M9.2 3H3C2.4 3 2 3.4 2 4V19C2 19.6 2.4 20 3 20H21C21.6 20 22 19.6 22 19V7C22 6.4 21.6 6 21 6H12L10.4 3.60001C10.2 3.20001 9.7 3 9.2 3Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                </svg>\r\n                                            </span>\r\n                                            <input");
				base.WriteLiteral(" type=\"text\"");
				base.WriteLiteral(" name=\"new_folder_name\"");
				base.WriteLiteral(" placeholder=\"Enter the folder name\"");
				base.WriteLiteral(" class=\"form-control mw-250px me-3\"");
				base.WriteLiteral(" />\r\n                                            <button");
				base.WriteLiteral(" class=\"btn btn-icon btn-light-primary me-3\"");
				base.WriteLiteral(" id=\"kt_file_manager_add_folder\"");
				base.WriteLiteral(">\r\n                                                <span");
				base.WriteLiteral(" class=\"indicator-label\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                        <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                            <path");
				base.WriteLiteral(" d=\"M9.89557 13.4982L7.79487 11.2651C7.26967 10.7068 6.38251 10.7068 5.85731 11.2651C5.37559 11.7772 5.37559 12.5757 5.85731 13.0878L9.74989 17.2257C10.1448 17.6455 10.8118 17.6455 11.2066 17.2257L18.1427 9.85252C18.6244 9.34044 18.6244 8.54191 18.1427 8.02984C17.6175 7.47154 16.7303 7.47154 16.2051 8.02984L11.061 13.4982C10.7451 13.834 10.2115 13.834 9.89557 13.4982Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                </span>\r\n                                                <span");
				base.WriteLiteral(" class=\"indicator-progress\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"spinner-border spinner-border-sm align-middle\"");
				base.WriteLiteral("></span>\r\n                                                </span>\r\n                                            </button>\r\n                                            <button");
				base.WriteLiteral(" class=\"btn btn-icon btn-light-danger\"");
				base.WriteLiteral(" id=\"kt_file_manager_cancel_folder\"");
				base.WriteLiteral(">\r\n                                                <span");
				base.WriteLiteral(" class=\"indicator-label\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                        <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                            <rect");
				base.WriteLiteral(" opacity=\"0.5\"");
				base.WriteLiteral(" x=\"7.05025\"");
				base.WriteLiteral(" y=\"15.5356\"");
				base.WriteLiteral(" width=\"12\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(-45 7.05025 15.5356)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                            <rect");
				base.WriteLiteral(" x=\"8.46447\"");
				base.WriteLiteral(" y=\"7.05029\"");
				base.WriteLiteral(" width=\"12\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(45 8.46447 7.05029)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                </span>\r\n                                                <span");
				base.WriteLiteral(" class=\"indicator-progress\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"spinner-border spinner-border-sm align-middle\"");
				base.WriteLiteral("></span>\r\n                                                </span>\r\n                                            </button>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td></td>\r\n                                    <td></td>\r\n                                    <td></td>\r\n                                </tr>\r\n                            </table>\r\n                            <div");
				base.WriteLiteral(" class=\"d-none\"");
				base.WriteLiteral(" data-kt-filemanager-template=\"rename\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"fv-row\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"d-flex align-items-center\"");
				base.WriteLiteral(">\r\n                                        <span");
				base.WriteLiteral(" id=\"kt_file_manager_rename_folder_icon\"");
				base.WriteLiteral("></span>\r\n                                        <input");
				base.WriteLiteral(" type=\"text\"");
				base.WriteLiteral(" id=\"kt_file_manager_rename_input\"");
				base.WriteLiteral(" name=\"rename_folder_name\"");
				base.WriteLiteral(" placeholder=\"Enter the new folder name\"");
				base.WriteLiteral(" class=\"form-control mw-250px me-3\"");
				base.WriteLiteral(" value=\"\"");
				base.WriteLiteral(" />\r\n                                        <button");
				base.WriteLiteral(" class=\"btn btn-sm btn-icon btn-light-primary me-3\"");
				base.WriteLiteral(" id=\"kt_file_manager_rename_folder\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                    <path");
				base.WriteLiteral(" d=\"M9.89557 13.4982L7.79487 11.2651C7.26967 10.7068 6.38251 10.7068 5.85731 11.2651C5.37559 11.7772 5.37559 12.5757 5.85731 13.0878L9.74989 17.2257C10.1448 17.6455 10.8118 17.6455 11.2066 17.2257L18.1427 9.85252C18.6244 9.34044 18.6244 8.54191 18.1427 8.02984C17.6175 7.47154 16.7303 7.47154 16.2051 8.02984L11.061 13.4982C10.7451 13.834 10.2115 13.834 9.89557 13.4982Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                </svg>\r\n                                            </span>\r\n                                        </button>\r\n                                        <button");
				base.WriteLiteral(" class=\"btn btn-sm btn-icon btn-light-danger\"");
				base.WriteLiteral(" id=\"kt_file_manager_rename_folder_cancel\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"indicator-label\"");
				base.WriteLiteral(">\r\n                                                <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                    <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                        <rect");
				base.WriteLiteral(" opacity=\"0.5\"");
				base.WriteLiteral(" x=\"7.05025\"");
				base.WriteLiteral(" y=\"15.5356\"");
				base.WriteLiteral(" width=\"12\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(-45 7.05025 15.5356)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                        <rect");
				base.WriteLiteral(" x=\"8.46447\"");
				base.WriteLiteral(" y=\"7.05029\"");
				base.WriteLiteral(" width=\"12\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(45 8.46447 7.05029)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                    </svg>\r\n                                                </span>\r\n                                            </span>\r\n                                            <span");
				base.WriteLiteral(" class=\"indicator-progress\"");
				base.WriteLiteral(">\r\n                                                <span");
				base.WriteLiteral(" class=\"spinner-border spinner-border-sm align-middle\"");
				base.WriteLiteral("></span>\r\n                                            </span>\r\n                                        </button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div");
				base.WriteLiteral(" class=\"d-none\"");
				base.WriteLiteral(" data-kt-filemanager-template=\"action\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"d-flex justify-content-end\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"ms-2\"");
				base.WriteLiteral(">\r\n                                        <button");
				base.WriteLiteral(" type=\"button\"");
				base.WriteLiteral(" class=\"btn btn-sm btn-icon btn-light btn-active-light-primary me-2\"");
				base.WriteLiteral(" data-kt-menu-trigger=\"click\"");
				base.WriteLiteral(" data-kt-menu-placement=\"bottom-end\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-5 m-0\"");
				base.WriteLiteral(">\r\n                                                <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                    <rect");
				base.WriteLiteral(" x=\"10\"");
				base.WriteLiteral(" y=\"10\"");
				base.WriteLiteral(" width=\"4\"");
				base.WriteLiteral(" height=\"4\"");
				base.WriteLiteral(" rx=\"2\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                    <rect");
				base.WriteLiteral(" x=\"17\"");
				base.WriteLiteral(" y=\"10\"");
				base.WriteLiteral(" width=\"4\"");
				base.WriteLiteral(" height=\"4\"");
				base.WriteLiteral(" rx=\"2\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                    <rect");
				base.WriteLiteral(" x=\"3\"");
				base.WriteLiteral(" y=\"10\"");
				base.WriteLiteral(" width=\"4\"");
				base.WriteLiteral(" height=\"4\"");
				base.WriteLiteral(" rx=\"2\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                </svg>\r\n                                            </span>\r\n                                        </button>\r\n                                        <div");
				base.WriteLiteral(" class=\"menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-semibold fs-7 w-150px py-4\"");
				base.WriteLiteral(" data-kt-menu=\"true\"");
				base.WriteLiteral(">\r\n");
				if (this.Model.CanMoveToFolder)
				{
					base.WriteLiteral("                                                <div");
					base.WriteLiteral(" class=\"menu-item px-3\"");
					base.WriteLiteral(">\r\n                                                    <a");
					base.WriteLiteral(" href=\"javascript:;\"");
					base.WriteLiteral(" class=\"menu-link px-3\"");
					base.WriteLiteral(" data-kt-filemanager-table-filter=\"move_row\"");
					base.WriteLiteral(" data-kt-filemanager-table=\"moveToFolder\"");
					base.WriteLiteral(" data-file-name=\"\"");
					base.WriteLiteral(">Move to folder</a>\r\n                                                </div>\r\n");
				}
				base.WriteLiteral("\r\n");
				if (this.Model.CanRename)
				{
					base.WriteLiteral("                                                <div");
					base.WriteLiteral(" class=\"menu-item px-3\"");
					base.WriteLiteral(">\r\n                                                    <a");
					base.WriteLiteral(" href=\"javascript:;\"");
					base.WriteLiteral(" class=\"menu-link px-3\"");
					base.WriteLiteral(" data-kt-filemanager-table=\"rename\"");
					base.WriteLiteral(">Rename</a>\r\n                                                </div>\r\n");
				}
				base.WriteLiteral("\r\n");
				if (this.Model.CanDelete)
				{
					base.WriteLiteral("                                                <div");
					base.WriteLiteral(" class=\"menu-item px-3\"");
					base.WriteLiteral(">\r\n                                                    <a");
					base.WriteLiteral(" href=\"#\"");
					base.WriteLiteral(" class=\"menu-link text-danger px-3\"");
					base.WriteLiteral(" data-kt-filemanager-table-filter=\"delete_row\"");
					base.WriteLiteral(">Delete</a>\r\n                                                </div>\r\n");
				}
				base.WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div");
				base.WriteLiteral(" class=\"d-none\"");
				base.WriteLiteral(" data-kt-filemanager-template=\"checkbox\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"form-check form-check-sm form-check-custom form-check-solid\"");
				base.WriteLiteral(">\r\n                                    <input");
				base.WriteLiteral(" class=\"form-check-input\"");
				base.WriteLiteral(" type=\"checkbox\"");
				base.WriteLiteral(" value=\"1\"");
				base.WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n                            <div");
				base.WriteLiteral(" class=\"modal fade\"");
				base.WriteLiteral(" id=\"kt_modal_upload\"");
				base.WriteLiteral(" tabindex=\"-1\"");
				base.WriteLiteral(" aria-hidden=\"true\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"modal-dialog modal-dialog-centered mw-650px\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"modal-content\"");
				base.WriteLiteral(">\r\n                                        <form");
				base.WriteLiteral(" class=\"form\"");
				base.WriteLiteral(" action=\"https://preview.keenthemes.com/metronic8/demo15/apps/file-manager/none\"");
				base.WriteLiteral(" id=\"kt_modal_upload_form\"");
				base.WriteLiteral(">\r\n                                            <div");
				base.WriteLiteral(" class=\"modal-header\"");
				base.WriteLiteral(">\r\n                                                <h2");
				base.WriteLiteral(" class=\"fw-bold\"");
				base.WriteLiteral(">Upload files</h2>\r\n                                                <div");
				base.WriteLiteral(" class=\"btn btn-icon btn-sm btn-active-icon-primary\"");
				base.WriteLiteral(" data-bs-dismiss=\"modal\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                        <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                            <rect");
				base.WriteLiteral(" opacity=\"0.5\"");
				base.WriteLiteral(" x=\"6\"");
				base.WriteLiteral(" y=\"17.3137\"");
				base.WriteLiteral(" width=\"16\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(-45 6 17.3137)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                            <rect");
				base.WriteLiteral(" x=\"7.41422\"");
				base.WriteLiteral(" y=\"6\"");
				base.WriteLiteral(" width=\"16\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(45 7.41422 6)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div");
				base.WriteLiteral(" class=\"modal-body pt-10 pb-15 px-lg-17\"");
				base.WriteLiteral(">\r\n                                                <div");
				base.WriteLiteral(" class=\"form-group\"");
				base.WriteLiteral(">\r\n                                                    <div");
				base.WriteLiteral(" class=\"dropzone dropzone-queue mb-2\"");
				base.WriteLiteral(" id=\"kt_modal_upload_dropzone\"");
				base.WriteLiteral(">\r\n                                                        <div");
				base.WriteLiteral(" class=\"dropzone-panel mb-4\"");
				base.WriteLiteral(">\r\n                                                            <a");
				base.WriteLiteral(" class=\"dropzone-select btn btn-sm btn-primary me-2\"");
				base.WriteLiteral(">Attach files</a>\r\n                                                            <a");
				base.WriteLiteral(" class=\"dropzone-upload btn btn-sm btn-light-primary me-2\"");
				base.WriteLiteral(">Upload All</a>\r\n                                                            <a");
				base.WriteLiteral(" class=\"dropzone-remove-all btn btn-sm btn-light-primary\"");
				base.WriteLiteral(">Remove All</a>\r\n                                                        </div>\r\n                                                        <div");
				base.WriteLiteral(" class=\"dropzone-items wm-200px\"");
				base.WriteLiteral(">\r\n                                                            <div");
				base.WriteLiteral(" class=\"dropzone-item p-5\"");
				base.WriteLiteral(" style=\"display:none\"");
				base.WriteLiteral(">\r\n                                                                <div");
				base.WriteLiteral(" class=\"dropzone-file\"");
				base.WriteLiteral(">\r\n                                                                    <div");
				base.WriteLiteral(" class=\"dropzone-filename text-dark\"");
				base.WriteLiteral(" title=\"some_image_file_name.jpg\"");
				base.WriteLiteral(">\r\n                                                                        <span");
				base.WriteLiteral(" data-dz-name=\"\"");
				base.WriteLiteral(">some_image_file_name.jpg</span>\r\n                                                                        <strong>\r\n                                                                            (\r\n                                                                            <span");
				base.WriteLiteral(" data-dz-size=\"\"");
				base.WriteLiteral(">340kb</span>)\r\n                                                                        </strong>\r\n                                                                    </div>\r\n                                                                    <div");
				base.WriteLiteral(" class=\"dropzone-error mt-0\"");
				base.WriteLiteral(" data-dz-errormessage=\"\"");
				base.WriteLiteral("></div>\r\n                                                                </div>\r\n                                                                <div");
				base.WriteLiteral(" class=\"dropzone-progress\"");
				base.WriteLiteral(">\r\n                                                                    <div");
				base.WriteLiteral(" class=\"progress bg-light-primary\"");
				base.WriteLiteral(">\r\n                                                                        <div");
				base.WriteLiteral(" class=\"progress-bar bg-primary\"");
				base.WriteLiteral(" role=\"progressbar\"");
				base.WriteLiteral(" aria-valuemin=\"0\"");
				base.WriteLiteral(" aria-valuemax=\"100\"");
				base.WriteLiteral(" aria-valuenow=\"0\"");
				base.WriteLiteral(" data-dz-uploadprogress=\"\"");
				base.WriteLiteral("></div>\r\n                                                                    </div>\r\n                                                                </div>\r\n                                                                <div");
				base.WriteLiteral(" class=\"dropzone-toolbar\"");
				base.WriteLiteral(">\r\n                                                                    <span");
				base.WriteLiteral(" class=\"dropzone-start\"");
				base.WriteLiteral(">\r\n                                                                        <i");
				base.WriteLiteral(" class=\"bi bi-play-fill fs-3\"");
				base.WriteLiteral("></i>\r\n                                                                    </span>\r\n                                                                    <span");
				base.WriteLiteral(" class=\"dropzone-cancel\"");
				base.WriteLiteral(" data-dz-remove=\"\"");
				base.WriteLiteral(" style=\"display: none;\"");
				base.WriteLiteral(">\r\n                                                                        <i");
				base.WriteLiteral(" class=\"bi bi-x fs-3\"");
				base.WriteLiteral("></i>\r\n                                                                    </span>\r\n                                                                    <span");
				base.WriteLiteral(" class=\"dropzone-delete\"");
				base.WriteLiteral(" data-dz-remove=\"\"");
				base.WriteLiteral(">\r\n                                                                        <i");
				base.WriteLiteral(" class=\"bi bi-x fs-1\"");
				base.WriteLiteral("></i>\r\n                                                                    </span>\r\n                                                                </div>\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                    <span");
				base.WriteLiteral(" class=\"form-text fs-6 text-muted\"");
				base.WriteLiteral(">Max file size is 1GB per file.</span>\r\n                                                </div>\r\n                                            </div>\r\n                                        </form>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div");
				base.WriteLiteral(" class=\"modal fade\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder\"");
				base.WriteLiteral(" tabindex=\"-1\"");
				base.WriteLiteral(" aria-hidden=\"true\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"modal-dialog modal-dialog-centered mw-650px\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"modal-content\"");
				base.WriteLiteral(">\r\n                                        <form");
				base.WriteLiteral(" class=\"form\"");
				base.WriteLiteral(" action=\"#\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder_form\"");
				base.WriteLiteral(">\r\n                                            <div");
				base.WriteLiteral(" class=\"modal-header\"");
				base.WriteLiteral(">\r\n                                                <h2");
				base.WriteLiteral(" class=\"fw-bold\"");
				base.WriteLiteral(">Move to folder</h2>\r\n                                                <div");
				base.WriteLiteral(" class=\"btn btn-icon btn-sm btn-active-icon-primary\"");
				base.WriteLiteral(" data-bs-dismiss=\"modal\"");
				base.WriteLiteral(">\r\n                                                    <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-1\"");
				base.WriteLiteral(">\r\n                                                        <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                            <rect");
				base.WriteLiteral(" opacity=\"0.5\"");
				base.WriteLiteral(" x=\"6\"");
				base.WriteLiteral(" y=\"17.3137\"");
				base.WriteLiteral(" width=\"16\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(-45 6 17.3137)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                            <rect");
				base.WriteLiteral(" x=\"7.41422\"");
				base.WriteLiteral(" y=\"6\"");
				base.WriteLiteral(" width=\"16\"");
				base.WriteLiteral(" height=\"2\"");
				base.WriteLiteral(" rx=\"1\"");
				base.WriteLiteral(" transform=\"rotate(45 7.41422 6)\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                        </svg>\r\n                                                    </span>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div");
				base.WriteLiteral(" class=\"modal-body pt-10 pb-15 px-lg-17\"");
				base.WriteLiteral(">\r\n                                                <div");
				base.WriteLiteral(" class=\"form-group fv-row\"");
				base.WriteLiteral(">\r\n                                                    <div");
				base.WriteLiteral(" class=\"d-flex\"");
				base.WriteLiteral(">\r\n                                                        <div");
				base.WriteLiteral(" class=\"form-check form-check-custom form-check-solid\"");
				base.WriteLiteral(">\r\n                                                            <input");
				base.WriteLiteral(" class=\"form-check-input me-3 move_to_folder\"");
				base.WriteLiteral(" name=\"move_to_folder\"");
				base.WriteLiteral(" type=\"radio\"");
				base.WriteLiteral(" value=\"/\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder_home\"");
				base.WriteLiteral(" />\r\n                                                            <label");
				base.WriteLiteral(" class=\"form-check-label\"");
				base.WriteLiteral(" for=\"kt_modal_move_to_folder_0\"");
				base.WriteLiteral(">\r\n                                                                <div");
				base.WriteLiteral(" class=\"fw-bold\"");
				base.WriteLiteral(">\r\n                                                                    <span");
				base.WriteLiteral(" class=\"svg-icon svg-icon-2 svg-icon-primary me-2\"");
				base.WriteLiteral(">\r\n                                                                        <svg");
				base.WriteLiteral(" width=\"24\"");
				base.WriteLiteral(" height=\"24\"");
				base.WriteLiteral(" viewBox=\"0 0 24 24\"");
				base.WriteLiteral(" fill=\"none\"");
				base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
				base.WriteLiteral(">\r\n                                                                            <path");
				base.WriteLiteral(" opacity=\"0.3\"");
				base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                                            <path");
				base.WriteLiteral(" d=\"M9.2 3H3C2.4 3 2 3.4 2 4V19C2 19.6 2.4 20 3 20H21C21.6 20 22 19.6 22 19V7C22 6.4 21.6 6 21 6H12L10.4 3.60001C10.2 3.20001 9.7 3 9.2 3Z\"");
				base.WriteLiteral(" fill=\"currentColor\"");
				base.WriteLiteral(" />\r\n                                                                        </svg>\r\n                                                                    </span>\r\n                                                                    Home\r\n                                                                </div>\r\n                                                            </label>\r\n                                                        </div>\r\n                                                    </div>\r\n");
				foreach (Tuple<string, string> item3 in this.Model.FolderPathList)
				{
					base.WriteLiteral("                                                        <div");
					base.WriteLiteral(" class='separator separator-dashed my-5'");
					base.WriteLiteral("></div>\r\n");
					base.WriteLiteral("                                                        <div");
					base.WriteLiteral(" class=\"d-flex\"");
					base.WriteLiteral(">\r\n                                                            <div");
					base.WriteLiteral(" class=\"form-check form-check-custom form-check-solid\"");
					base.WriteLiteral(">\r\n                                                                <input");
					base.WriteLiteral(" class=\"form-check-input me-3 move_to_folder\"");
					base.WriteLiteral(" name=\"move_to_folder\"");
					base.WriteLiteral(" type=\"radio\"");
					base.WriteAttribute("value", " value=\"", "\"", new Tuple<string, object, bool>[]
					{
						Tuple.Create<string, object, bool>("", item3.Item2, false)
					});
					base.WriteAttribute("id", " id=\"", "\"", new Tuple<string, object, bool>[]
					{
						Tuple.Create<string, object, bool>("", "kt_modal_move_to_folder_", true),
						Tuple.Create<string, object, bool>("", item3.Item2, false)
					});
					base.WriteLiteral(" />\r\n                                                                <label");
					base.WriteLiteral(" class=\"form-check-label\"");
					base.WriteAttribute("for", " for=\"", "\"", new Tuple<string, object, bool>[]
					{
						Tuple.Create<string, object, bool>("", "kt_modal_move_to_folder_", true),
						Tuple.Create<string, object, bool>("", item3.Item2, false)
					});
					base.WriteLiteral(">\r\n                                                                    <div");
					base.WriteLiteral(" class=\"fw-bold\"");
					base.WriteLiteral(">\r\n                                                                        <span");
					base.WriteLiteral(" class=\"svg-icon svg-icon-2 svg-icon-primary me-2\"");
					base.WriteLiteral(">\r\n                                                                            <svg");
					base.WriteLiteral(" width=\"24\"");
					base.WriteLiteral(" height=\"24\"");
					base.WriteLiteral(" viewBox=\"0 0 24 24\"");
					base.WriteLiteral(" fill=\"none\"");
					base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
					base.WriteLiteral(">\r\n                                                                                <path");
					base.WriteLiteral(" opacity=\"0.3\"");
					base.WriteLiteral(" d=\"M10 4H21C21.6 4 22 4.4 22 5V7H10V4Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                                <path");
					base.WriteLiteral(" d=\"M9.2 3H3C2.4 3 2 3.4 2 4V19C2 19.6 2.4 20 3 20H21C21.6 20 22 19.6 22 19V7C22 6.4 21.6 6 21 6H12L10.4 3.60001C10.2 3.20001 9.7 3 9.2 3Z\"");
					base.WriteLiteral(" fill=\"currentColor\"");
					base.WriteLiteral(" />\r\n                                                                            </svg>\r\n                                                                        </span>\r\n");
					base.WriteLiteral("                                                                        ");
					base.Write(item3.Item2);
					base.WriteLiteral("\r\n                                                                    </div>\r\n                                                                </label>\r\n                                                            </div>\r\n                                                        </div>\r\n");
				}
				base.WriteLiteral("                                                </div>\r\n                                                <div");
				base.WriteLiteral(" class=\"d-flex flex-center mt-12\"");
				base.WriteLiteral(">\r\n                                                    <button");
				base.WriteLiteral(" type=\"button\"");
				base.WriteLiteral(" class=\"btn btn-primary\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder_submit\"");
				base.WriteLiteral(">\r\n                                                        <span");
				base.WriteLiteral(" class=\"indicator-label\"");
				base.WriteLiteral(">Save</span>\r\n                                                        <span");
				base.WriteLiteral(" class=\"indicator-progress\"");
				base.WriteLiteral(">\r\n                                                            Please wait...\r\n                                                            <span");
				base.WriteLiteral(" class=\"spinner-border spinner-border-sm align-middle ms-2\"");
				base.WriteLiteral("></span>\r\n                                                        </span>\r\n                                                    </button>\r\n                                                </div>\r\n                                            </div>\r\n                                        </form>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div");
				base.WriteLiteral(" class=\"modal fade\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder\"");
				base.WriteLiteral(" tabindex=\"-1\"");
				base.WriteLiteral(" aria-hidden=\"true\"");
				base.WriteLiteral(">\r\n                                <div");
				base.WriteLiteral(" class=\"modal-dialog modal-dialog-centered mw-650px\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"modal-content\"");
				base.WriteLiteral(">\r\n                                        <form");
				base.WriteLiteral(" class=\"form\"");
				base.WriteLiteral(" action=\"#\"");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder_form\"");
				base.WriteLiteral(">\r\n                                            <button");
				base.WriteLiteral(" id=\"kt_modal_move_to_folder_submit\"");
				base.WriteLiteral(" class=\"btn btn-sm\"");
				base.WriteLiteral("></button>\r\n                                        </form>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
			}
			else
			{
				base.WriteLiteral("                    <div");
				base.WriteLiteral(" class=\"content d-flex flex-column flex-column-fluid\"");
				base.WriteLiteral(" id=\"kt_content\"");
				base.WriteLiteral(">\r\n                        <div");
				base.WriteLiteral(" class=\"container\"");
				base.WriteLiteral(" id=\"kt_content_container\"");
				base.WriteLiteral(">\r\n                            <div");
				base.WriteLiteral(" class=\"card-body p-10 p-lg-20\"");
				base.WriteLiteral(">\r\n                                <form");
				base.WriteLiteral(" class=\"form w-100 fv-plugins-bootstrap5 fv-plugins-framework\"");
				base.WriteLiteral(" novalidate=\"novalidate\"");
				base.WriteLiteral(" id=\"kt_sign_in_form\"");
				base.WriteLiteral(" data-kt-redirect-url=\"/\"");
				base.WriteLiteral(" action=\"/LogOT3YUsadhd7qPuALBXVhnsDdAUinA0\"");
				base.WriteLiteral(">\r\n                                    <div");
				base.WriteLiteral(" class=\"text-center mb-11 container col-xl-6 col-lg-6 col-md-6\"");
				base.WriteLiteral(">\r\n                                        <h1");
				base.WriteLiteral(" class=\"text-dark fw-bolder mb-3\"");
				base.WriteLiteral(">Sign In</h1>\r\n                                    </div>\r\n                                    <div");
				base.WriteLiteral(" class=\"fv-row mb-8 fv-plugins-icon-container container col-xl-6 col-lg-6 col-md-6\"");
				base.WriteLiteral(">\r\n                                        <input");
				base.WriteLiteral(" type=\"text\"");
				base.WriteLiteral(" placeholder=\"User Name\"");
				base.WriteLiteral(" name=\"UserName\"");
				base.WriteLiteral(" autocomplete=\"off\"");
				base.WriteLiteral(" class=\"form-control bg-transparent\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"fv-plugins-message-container invalid-feedback\"");
				base.WriteLiteral("></div>\r\n                                    </div>\r\n                                    <div");
				base.WriteLiteral(" class=\"fv-row mb-3 fv-plugins-icon-container container col-xl-6 col-lg-6 col-md-6\"");
				base.WriteLiteral(">\r\n                                        <input");
				base.WriteLiteral(" type=\"password\"");
				base.WriteLiteral(" placeholder=\"Password\"");
				base.WriteLiteral(" name=\"password\"");
				base.WriteLiteral(" autocomplete=\"off\"");
				base.WriteLiteral(" class=\"form-control bg-transparent\"");
				base.WriteLiteral(">\r\n                                        <div");
				base.WriteLiteral(" class=\"fv-plugins-message-container invalid-feedback\"");
				base.WriteLiteral("></div>\r\n                                    </div>\r\n                                    <div");
				base.WriteLiteral(" class=\"d-grid mt-10 container col-xl-6 col-lg-6 col-md-6\"");
				base.WriteLiteral(">\r\n                                        <button");
				base.WriteLiteral(" type=\"submit\"");
				base.WriteLiteral(" id=\"kt_sign_in_submit\"");
				base.WriteLiteral(" class=\"btn btn-primary\"");
				base.WriteLiteral(">\r\n                                            <span");
				base.WriteLiteral(" class=\"indicator-label\"");
				base.WriteLiteral(">Sign In</span>\r\n                                        </button>\r\n                                    </div>\r\n                                    <p");
				base.WriteLiteral(" class=\"container col-xl-6 col-lg-6 col-md-6\"");
				base.WriteLiteral(" style=\"color:orangered\"");
				base.WriteLiteral(">");
				base.Write(this.Model.WrongPasswordMessage);
				base.WriteLiteral("</p>\r\n                                </form>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
			}
			base.WriteLiteral("                ");
			base.WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
			base.WriteLiteral("\r\n    <div");
			base.WriteLiteral(" id=\"kt_scrolltop\"");
			base.WriteLiteral(" class=\"scrolltop\"");
			base.WriteLiteral(" data-kt-scrolltop=\"true\"");
			base.WriteLiteral(">\r\n        <span");
			base.WriteLiteral(" class=\"svg-icon\"");
			base.WriteLiteral(">\r\n            <svg");
			base.WriteLiteral(" width=\"24\"");
			base.WriteLiteral(" height=\"24\"");
			base.WriteLiteral(" viewBox=\"0 0 24 24\"");
			base.WriteLiteral(" fill=\"none\"");
			base.WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");
			base.WriteLiteral(">\r\n                <rect");
			base.WriteLiteral(" opacity=\"0.5\"");
			base.WriteLiteral(" x=\"13\"");
			base.WriteLiteral(" y=\"6\"");
			base.WriteLiteral(" width=\"13\"");
			base.WriteLiteral(" height=\"2\"");
			base.WriteLiteral(" rx=\"1\"");
			base.WriteLiteral(" transform=\"rotate(90 13 6)\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n                <path");
			base.WriteLiteral(" d=\"M12.5657 8.56569L16.75 12.75C17.1642 13.1642 17.8358 13.1642 18.25 12.75C18.6642 12.3358 18.6642 11.6642 18.25 11.25L12.7071 5.70711C12.3166 5.31658 11.6834 5.31658 11.2929 5.70711L5.75 11.25C5.33579 11.6642 5.33579 12.3358 5.75 12.75C6.16421 13.1642 6.83579 13.1642 7.25 12.75L11.4343 8.56569C11.7467 8.25327 12.2533 8.25327 12.5657 8.56569Z\"");
			base.WriteLiteral(" fill=\"currentColor\"");
			base.WriteLiteral(" />\r\n            </svg>\r\n        </span>\r\n    </div>\r\n\r\n    <script>var hostUrl = \"https://cdn.localtonet.com/fileserver\";</script>\r\n    <script");
			base.WriteLiteral(" src=\"https://cdn.localtonet.com/fileserver/js/plugins.bundle.js\"");
			base.WriteLiteral("></script>\r\n    <script");
			base.WriteLiteral(" src=\"https://cdn.localtonet.com/fileserver/js/scripts.bundle.js\"");
			base.WriteLiteral("></script>\r\n    <script");
			base.WriteLiteral(" src=\"https://cdn.localtonet.com/fileserver/js/datatables.bundle.js\"");
			base.WriteLiteral("></script>\r\n    <script");
			base.WriteLiteral(" src=\"https://cdn.localtonet.com/fileserver/js/list.js\"");
			base.WriteLiteral("></script>\r\n    <script>\r\n        function logOut() {\r\n            clearCookie();\r\n            location.reload();\r\n        }\r\n\r\n        function loginAsGuest() {\r\n            clearCookie();\r\n            window.location = '/';\r\n        }\r\n\r\n        function clearCookie() {\r\n            document.cookie.split(\";\").forEach(function (cookie) {\r\n                document.cookie = cookie.replace(/^ +/, \"\").replace(/=.*/, \"=;expires=\" + new Date().toUTCString() + \";path=/\");\r\n            });\r\n        }\r\n    </script>\r\n</body>\r\n</html>");
		}
	}
}
