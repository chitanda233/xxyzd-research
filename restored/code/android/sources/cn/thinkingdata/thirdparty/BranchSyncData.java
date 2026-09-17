package cn.thinkingdata.thirdparty;

import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes.dex */
public class BranchSyncData extends AbstractSyncThirdData {
    public BranchSyncData(String str, String str2) {
        super(str, str2);
    }

    @Override // cn.thinkingdata.thirdparty.ISyncThirdPartyData
    public void syncThirdPartyData() {
        TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: start enabled sharing of data to branch");
        try {
            Class<?> cls = Class.forName("io.branch.referral.Branch");
            Object objInvoke = cls.getMethod("getInstance", new Class[0]).invoke(null, new Object[0]);
            Method method = cls.getMethod("setRequestMetadata", String.class, String.class);
            Object[] objArr = new Object[2];
            objArr[0] = TAThirdConstants.TA_DISTINCT_ID;
            String str = "";
            objArr[1] = this.distinctId == null ? "" : this.distinctId;
            method.invoke(objInvoke, objArr);
            Object[] objArr2 = new Object[2];
            objArr2[0] = TAThirdConstants.TA_ACCOUNT_ID;
            if (this.accountId != null) {
                str = this.accountId;
            }
            objArr2[1] = str;
            method.invoke(objInvoke, objArr2);
            TDLog.i("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to branch success");
        } catch (Exception e) {
            TDLog.e("ThinkingAnalytics.SyncData", "[ThinkingData] Info: enabled sharing of data to branch error:" + e.getMessage());
        }
    }
}
