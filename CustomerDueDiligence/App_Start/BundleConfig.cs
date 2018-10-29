using System.Web;
using System.Web.Optimization;

namespace CustomerDueDiligence
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/bower_components/jquery/dist/jquery.min.js",
                        "~/Content/bower_components/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Content/bower_components/Ionicons/css/ionicons.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                      "~/Content/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                      "~/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                      "~/Content/bower_components/Chart.js/Chart.js"));

            //App
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Content/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                      "~/Content/bower_components/fastclick/lib/fastclick.js",
                      "~/Scripts/js/adminlte.min.js",
                      "~/Scripts/js/demo.js",
                      "~/Scripts/typeahead.bundle.js",
                      "~/Scripts/toastr.js",
                      "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/app").Include(
                      "~/Content/toastr.css",
                      "~/Content/css/AdminLTE.min.css",
                      "~/Content/css/skins/_all-skins.min.css"));


            // dataTable
            bundles.Add(new ScriptBundle("~/bundles/dataTables-js").Include(
                      "~/Content/bower_components/datatables.net/js/jquery.dataTables.min.js",
                      "~/Content/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/dataTables-css").Include(
                     "~/Content/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"));

            //forms
            bundles.Add(new StyleBundle("~/Content/forms-css").Include(
                     "~/Content/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                     "~/Content/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                     "~/Scripts/plugins/iCheck/all.css",
                     "~/Content/bower_components/bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css",
                     "~/Scripts/plugins/timepicker/bootstrap-timepicker.min.css",
                     "~/Content/bower_components/select2/dist/css/select2.min.css",
                     "~/Content/Site.css",
                     "~/Content/css/typeahead.css"));

            bundles.Add(new ScriptBundle("~/bundles/forms-js").Include(
                      "~/Content/bower_components/select2/dist/js/select2.full.min.js",
                      "~/Scripts/plugins/input-mask/jquery.inputmask.js",
                      "~/Scripts/plugins/input-mask/jquery.inputmask.date.extensions.js",
                      "~/Scripts/plugins/input-mask/jquery.inputmask.extensions.js",
                      "~/Content/bower_components/moment/min/moment.min.js",
                      "~/Content/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                      "~/Content/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                      "~/Content/bower_components/bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js",
                      "~/Scripts/plugins/timepicker/bootstrap-timepicker.min.js",
                      "~/Scripts/plugins/iCheck/icheck.min.js"));
        }
    }
}
