package com.unicom.online.account.kernel;

import android.text.TextUtils;
import com.byazt.nys.PluginConstants;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class f {
    public final /* synthetic */ i b;

    public f(i iVar) {
        this.b = iVar;
    }

    public final void b(int i, int i2, String str) {
        String strB;
        synchronized (this.b) {
            if (this.b.e == null) {
                return;
            }
            if (i2 == 1) {
                try {
                    JSONObject jSONObject = new JSONObject(str);
                    int iOptInt = jSONObject.optInt(PluginConstants.KEY_ERROR_CODE);
                    String strOptString = jSONObject.optString("msg");
                    String strOptString2 = jSONObject.optString("data");
                    String strOptString3 = jSONObject.optString("seq");
                    if (bh.b(strOptString3).booleanValue()) {
                        strOptString3 = bp.c();
                    }
                    String str2 = strOptString3;
                    as.b("Code =" + iOptInt);
                    av avVar = this.b.e;
                    if (iOptInt == 100) {
                        String strC = ao.c();
                        String strSubstring = strC.substring(0, 16);
                        String strSubstring2 = strC.substring(16, 32);
                        if (ap.g) {
                            byte[] bArrB = aq.b(strOptString2);
                            byte[] bytes = strSubstring.getBytes();
                            byte[] bytes2 = strSubstring2.getBytes();
                            ad.c.getClass();
                            strB = new String(bc.b(bytes, bytes2, bArrB, 2));
                        } else {
                            try {
                                strB = b.b(strOptString2, strSubstring, strSubstring2);
                            } catch (Exception e) {
                                as.b(e);
                                strB = null;
                            }
                        }
                        if (TextUtils.isEmpty(strB)) {
                            as.b("\nmsg=" + strOptString + "\ndata=" + strOptString2 + "\nseq=" + str2 + "\n", 2);
                            this.b.e.b(i, 410002, "返回数据异常", strOptString2, str2);
                        } else {
                            as.b("\nmsg=" + strOptString + "\ncontent=" + strB + "\nseq=" + str2 + "\n", 2);
                            this.b.e.b(strOptString, strB, str2);
                        }
                    } else {
                        String str3 = (iOptInt != -2 || TextUtils.isEmpty(ao.t)) ? strOptString : strOptString + "apn is " + ao.t;
                        as.b("\nmsg=" + str3 + "\ndata=" + strOptString2 + "\nseq=" + str2 + "\n", 2);
                        this.b.e.b(i, iOptInt, str3, strOptString2, str2);
                    }
                } catch (Exception e2) {
                    as.b("\nresponse=" + str + "\n", 2);
                    this.b.e.b(i, 410002, "返回数据异常" + e2.getMessage(), str, "");
                }
            } else {
                as.b("\nresponse=" + str + "\n", 2);
                this.b.e.b(i, i2, str, "", bp.c());
            }
            i iVar = this.b;
            iVar.e = null;
            iVar.b("请求完成");
        }
    }
}
