package cn.thinkingdata.thirdparty;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public abstract class AbstractSyncThirdData implements ISyncThirdPartyData {
    protected static final String TAG = "ThinkingAnalytics.SyncData";
    protected String accountId;
    protected String distinctId;

    public AbstractSyncThirdData() {
    }

    public AbstractSyncThirdData(String str) {
        this.distinctId = str;
    }

    public AbstractSyncThirdData(String str, String str2) {
        this.distinctId = str;
        this.accountId = str2;
    }

    protected Map<String, Object> handleMap(Object obj) {
        if (!(obj instanceof Map)) {
            return null;
        }
        HashMap map = new HashMap();
        Map map2 = (Map) obj;
        for (Object obj2 : map2.keySet()) {
            if (obj2 instanceof String) {
                map.put((String) obj2, map2.get(obj2));
            }
        }
        return map;
    }
}
