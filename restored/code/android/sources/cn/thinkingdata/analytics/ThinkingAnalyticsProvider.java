package cn.thinkingdata.analytics;

import android.util.Pair;
import cn.thinkingdata.analytics.e.e;
import cn.thinkingdata.analytics.h.o;
import cn.thinkingdata.core.router.provider.IAnalyticsProvider;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class ThinkingAnalyticsProvider implements IAnalyticsProvider {
    @Override // cn.thinkingdata.core.router.provider.IAnalyticsProvider
    public Map<String, Object> getAnalyticsProperties(String str) {
        HashMap map = new HashMap();
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str);
        if (tDAnalyticsAPI == null) {
            tDAnalyticsAPI = ThinkingAnalyticsSDK.getInstanceByAppId(str);
        }
        if (tDAnalyticsAPI != null) {
            map.put("#zone_offset", tDAnalyticsAPI.mCalibratedTimeManager.a().a());
            Map<String, Object> mapE = e.b(tDAnalyticsAPI.mConfig.mContext).e();
            map.put("#install_time", mapE.get("#install_time"));
            map.put("#lib", mapE.get("#lib"));
            map.put("#lib_version", mapE.get("#lib_version"));
        }
        return map;
    }

    @Override // cn.thinkingdata.core.router.provider.IAnalyticsProvider
    public Pair<Long, Boolean> getCurrentTimeStamp() {
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance("");
        if (tDAnalyticsAPI == null) {
            tDAnalyticsAPI = ThinkingAnalyticsSDK.getInstanceByAppId("");
        }
        if (tDAnalyticsAPI != null) {
            cn.thinkingdata.analytics.h.e eVarA = tDAnalyticsAPI.mCalibratedTimeManager.a();
            if (eVarA instanceof o) {
                return new Pair<>(Long.valueOf(((o) eVarA).c().getTime()), true);
            }
        }
        return new Pair<>(Long.valueOf(new Date().getTime()), false);
    }

    @Override // cn.thinkingdata.core.router.provider.IAnalyticsProvider
    public String getDistinctId(String str) {
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str);
        if (tDAnalyticsAPI == null) {
            tDAnalyticsAPI = ThinkingAnalyticsSDK.getInstanceByAppId(str);
        }
        return tDAnalyticsAPI != null ? tDAnalyticsAPI.getDistinctId() : "";
    }

    @Override // cn.thinkingdata.core.router.provider.IAnalyticsProvider
    public String getLoginId(String str) {
        ThinkingAnalyticsSDK tDAnalyticsAPI = TDAnalyticsAPI.getInstance(str);
        if (tDAnalyticsAPI == null) {
            tDAnalyticsAPI = ThinkingAnalyticsSDK.getInstanceByAppId(str);
        }
        return tDAnalyticsAPI != null ? tDAnalyticsAPI.getLoginId() : "";
    }
}
