package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class TopOnSyncData extends AbstractSyncThirdData {
    private final Map<String, Object> mCustomMap;

    public TopOnSyncData(String str, Object obj) {
        super(str);
        this.mCustomMap = handleMap(obj);
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to TopOn");
        try {
            Method method = Class.forName("com.anythink.core.api.ATSDK").getMethod("initCustomMap", Map.class);
            HashMap map = new HashMap();
            map.put((String) Class.forName("com.anythink.core.api.ATCustomRuleKeys").getField("USER_ID").get(null), this.distinctId == null ? "" : this.distinctId);
            Map<String, Object> map2 = this.mCustomMap;
            if (map2 != null) {
                for (Map.Entry<String, Object> entry : map2.entrySet()) {
                    map.put(entry.getKey(), entry.getValue());
                }
            }
            method.invoke(null, map);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TopOn success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TopOn error:" + e.getMessage());
        }
    }
}
