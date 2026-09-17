package cn.thinkingdata.core.router;

import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes.dex */
public class LogisticsCenter {
    public static Map<String, RouteMeta> plugins = new HashMap();
    public static Map<String, RouteMeta> routes;

    public interface OnLoadPluginCallBack {
        void onPluginLoadSuccess(Set<String> set);
    }

    public static boolean completion(Postcard postcard) {
        RouteMeta routeMeta = plugins.get(postcard.getPath());
        if (routeMeta == null) {
            routeMeta = routes.get(postcard.getPath());
        }
        if (routeMeta == null) {
            return false;
        }
        postcard.setType(routeMeta.getType());
        postcard.setClassName(routeMeta.getClassName());
        postcard.setNeedCache(routeMeta.isNeedCache());
        return true;
    }

    public static synchronized void init() {
        routes = TRouterMap.getDefaultRouters();
    }
}
