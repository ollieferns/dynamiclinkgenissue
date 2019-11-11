using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace LinkGenTest {
    public class DummyDynamicRouteValueTransformer : DynamicRouteValueTransformer {
        public DummyDynamicRouteValueTransformer() {
        }

        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values) {

            var returnedValues = new RouteValueDictionary();


            if (values?["controller"] is null) {
                returnedValues["controller"] = "Home";
            } else {
                returnedValues["controller"] = values?["controller"];
            }

            if (values?["action"] is null) {
                returnedValues["action"] = "Index";
            } else {
                returnedValues["action"] = values?["action"];
            }

            return new ValueTask<RouteValueDictionary>(Task.FromResult(returnedValues));
        }
    }
}   