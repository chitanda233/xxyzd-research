package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class TradPlusSyncData extends AbstractSyncThirdData {
    public TradPlusSyncData(String str) {
        super(str);
    }

    private void syncThirdPartyData1() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to TradPlus");
        try {
            Method method = Class.forName("com.tradplus.ads.base.util.SegmentUtils").getMethod("initCustomMap", Map.class);
            HashMap map = new HashMap();
            map.put((String) Class.forName("com.tradplus.ads.base.util.AppKeyManager").getField("CUSTOM_USERID").get(null), this.distinctId == null ? "" : this.distinctId);
            method.invoke(null, map);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TradPlus success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TradPlus error:" + e.getMessage());
        }
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to TradPlus");
        try {
            Method method = Class.forName("com.tradplus.ads.mobileads.util.SegmentUtils").getMethod("initCustomMap", Map.class);
            HashMap map = new HashMap();
            map.put((String) Class.forName("com.tradplus.ads.mobileads.util.AppKeyManager").getField("CUSTOM_USERID").get(null), this.distinctId == null ? "" : this.distinctId);
            method.invoke(null, map);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TradPlus success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to TradPlus error:" + e.getMessage());
            syncThirdPartyData1();
        }
    }
}
