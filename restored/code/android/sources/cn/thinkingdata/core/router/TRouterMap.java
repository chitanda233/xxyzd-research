package cn.thinkingdata.core.router;

import android.text.TextUtils;
import com.alipay.sdk.m.n.c;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TRouterMap {
    public static final String ANALYTIC_PROVIDER_ROUTE_PATH = "/thinkingdata/provider/analytic";
    public static final String ANALYTIC_ROUTE_PATH = "/thinkingdata/analytic";
    public static final String DOT = ".";
    public static final String PRESET_TEMPLATE_ROUTE_PATH = "/thingkingdata/preset/template";
    public static final String PUSH_ROUTE_PATH = "/thinkingdata/tpush";
    public static final String RCC_PLUGIN_ROUTE_PATH = "/thingkingdata/plugin/rcc";
    public static final String ROUTE_ROOT_PACKAGE = "cn.thinkingdata.module.routes";
    public static final String SENSITIVE_PROPERTIES_ROUTE_PATH = "/thingkingdata/sensitive/properties";
    public static final String STRATEGY_PLUGIN_ROUTE_PATH = "/thingkingdata/plugin/strategy";
    public static final String SUFFIX_NAME = "ModuleRouter";
    private static final String TAG = "ThinkingAnalytics.TRouterMap";
    private static final String[] modules = {"ThirdParty", "Analytic", "PresetTemplate", "SensitiveProperties", "RemoteConfig", "Strategy"};

    public static Map<String, RouteMeta> getDefaultRouters() {
        HashMap map = new HashMap();
        for (String str : modules) {
            try {
                Map map2 = (Map) Class.forName("cn.thinkingdata.module.routes." + str + SUFFIX_NAME).getDeclaredMethod("getRouterMap", new Class[0]).invoke(null, new Object[0]);
                if (map2 != null) {
                    for (String str2 : map2.keySet()) {
                        String str3 = (String) map2.get(str2);
                        if (str3 != null && !TextUtils.isEmpty(str3)) {
                            JSONObject jSONObject = new JSONObject(str3);
                            map.put(str2, RouteMeta.build(RouteType.parse(jSONObject.optInt("type")), str2, jSONObject.optString(c.e), jSONObject.optBoolean("needCache")));
                        }
                    }
                }
            } catch (ClassNotFoundException unused) {
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return map;
    }
}
