package cn.thinkingdata.module.routes;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class ThirdPartyModuleRouter {
    public static Map<String, String> getRouterMap() {
        HashMap map = new HashMap();
        map.put("/thingkingdata/third/party", "{name=cn.thinkingdata.thirdparty.ThirdPartyPlugin, needCache=true, type=1}");
        return map;
    }
}
