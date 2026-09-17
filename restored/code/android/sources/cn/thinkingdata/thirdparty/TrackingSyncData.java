package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes.dex */
public class TrackingSyncData extends AbstractSyncThirdData {
    public TrackingSyncData(String str) {
        super(str);
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to hot cloud");
        try {
            Method method = Class.forName("com.reyun.tracking.sdk.Tracking").getMethod("setRegisterWithAccountID", String.class);
            Object[] objArr = new Object[1];
            objArr[0] = this.distinctId == null ? "" : this.distinctId;
            method.invoke(null, objArr);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to hot cloud success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to hot cloud error:" + e.getMessage());
        }
    }
}
