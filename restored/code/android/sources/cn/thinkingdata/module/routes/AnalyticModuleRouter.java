package cn.thinkingdata.module.routes;

import cn.thinkingdata.core.router.TRouterMap;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class AnalyticModuleRouter {
    public static Map<String, String> getRouterMap() {
        HashMap map = new HashMap();
        map.put(TRouterMap.ANALYTIC_ROUTE_PATH, "{name=cn.thinkingdata.analytics.ThinkingAnalyticsPlugin, needCache=true, type=1}");
        map.put(TRouterMap.ANALYTIC_PROVIDER_ROUTE_PATH, "{name=cn.thinkingdata.analytics.ThinkingAnalyticsProvider, needCache=true, type=0}");
        return map;
    }
}
