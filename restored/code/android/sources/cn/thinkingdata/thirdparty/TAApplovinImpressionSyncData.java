package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.Iterator;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class TAApplovinImpressionSyncData extends AbstractSyncThirdData {
    public TAApplovinImpressionSyncData(String str) {
        super(str);
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to ApplovinImpression");
        try {
            Class<?> cls = Class.forName("com.applovin.sdk.AppLovinSdk");
            Field declaredField = cls.getDeclaredField("sdkInstances");
            declaredField.setAccessible(true);
            Map map = (Map) declaredField.get(null);
            Method method = cls.getMethod("setUserIdentifier", String.class);
            if (map != null) {
                Iterator it = map.keySet().iterator();
                while (it.hasNext()) {
                    method.invoke(map.get((String) it.next()), this.distinctId);
                }
            }
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to ApplovinImpression success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to ApplovinImpression error：" + e.getMessage());
        }
    }
}
