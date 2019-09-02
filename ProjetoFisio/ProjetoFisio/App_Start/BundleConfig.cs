using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace ProjetoFisio
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o Agrupamento, visite https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // A ordem é muito importante para que esses arquivos funcionem; eles possuem dependências explícitas
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Use a versão de Desenvolvimento do Modernizr para se desenvolver e aprender com ele. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jsBefore").Include(
                            //"~/Scripts/jsBefore/google-map.js",
                            "~/Scripts/jsBefore/scrollax.min.js",
                            "~/Scripts/jsBefore/range.js",
                            "~/Scripts/jsBefore/jquery-3.2.1.min.js",
                            "~/Scripts/jsBefore/jquery.min.js",
                            "~/Scripts/jsBefore/bootstrap.min.js",
                            "~/Scripts/jsBefore/aos.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsExterno").Include(
                            "~/Scripts/jsExterno/jquery-migrate-3.0.1.min.js",
                            "~/Scripts/jsExterno/jquery.animateNumber.min.js",
                            "~/Scripts/jsExterno/jquery.magnific-popup.min.js",
                            "~/Scripts/jsExterno/jquery.stellar.min.js",
                            "~/Scripts/jsExterno/jquery.timepicker.min.js",
                            "~/Scripts/jsExterno/jquery.waypoints.min.js",
                            "~/Scripts/jsExterno/jquery.easing.1.3.js",
                            "~/Scripts/jsExterno/owl.carousel.min.js",
                            "~/Scripts/jsExterno/popper.min.js",
                            "~/Scripts/jsExterno/bootstrap-datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsLast").Include(
                            "~/Scripts/jsBefore/main.js"));
        }
    }
}