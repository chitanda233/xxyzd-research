package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import cn.com.chinatelecom.account.api.Helper;
import cn.com.chinatelecom.account.api.encrypt.StringUtil;

/* JADX INFO: loaded from: classes.dex */
public class SoParamProvider implements ParamProvider {
    @Override // cn.com.chinatelecom.account.api.utils.ParamProvider
    public String getPreLoginUrl(boolean z) {
        return Helper.cepahsul(z);
    }

    @Override // cn.com.chinatelecom.account.api.utils.ParamProvider
    public String getPreLoginParams(Context context, String str, String str2, String str3, long j, boolean z, String str4) {
        return Helper.dnepah(context, str, str2, str3, j, false, z, str4);
    }

    @Override // cn.com.chinatelecom.account.api.utils.ParamProvider
    public String decryptPreLoginResult(String str, String str2) {
        try {
            byte[] bArrDnepmret = Helper.dnepmret(StringUtil.hexToBytes(str), str2);
            return bArrDnepmret == null ? "" : new String(bArrDnepmret);
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }

    @Override // cn.com.chinatelecom.account.api.utils.ParamProvider
    public String getPreCodeParamsByJs(Context context, long j, String str) {
        return Helper.dnprecobjs(context, j, str);
    }
}
