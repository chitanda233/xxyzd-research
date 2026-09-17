package com.qq.gdt.action.h;

import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kuaishou.weapon.p0.t;
import com.qq.e.comm.constants.ErrorCode;
import com.qq.gdt.action.d;
import com.qq.gdt.action.i.f;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.v;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    public interface a {
        void a(List<com.qq.gdt.action.b.a> list, int i, String str, int i2, String str2);

        void a(List<com.qq.gdt.action.b.a> list, boolean z);
    }

    public static void a(List<com.qq.gdt.action.b.a> list, long j, String str, int i, String str2, int i2) {
        try {
            for (com.qq.gdt.action.b.a aVar : list) {
                JSONObject jSONObject = new JSONObject();
                jSONObject.putOpt(MediationConstant.EXTRA_DURATION, Long.valueOf(System.currentTimeMillis() - j));
                jSONObject.putOpt("httpStatus", Integer.valueOf(i2));
                jSONObject.putOpt("actionType", aVar.c());
                jSONObject.putOpt("actionTime", Long.valueOf(aVar.d()));
                jSONObject.putOpt("uniqActionId", aVar.a());
                jSONObject.putOpt(MediationConstant.KEY_ERROR_CODE, Integer.valueOf(i));
                jSONObject.putOpt(MediationConstant.KEY_ERROR_MSG, str2);
                jSONObject.putOpt("requestCgi", str);
                JSONObject jSONObjectA = d.a().a(jSONObject);
                if (i != 0) {
                    com.qq.gdt.action.g.a.a(ErrorCode.PrivateError.AD_DATA_DESTROYED, aVar, jSONObjectA);
                }
            }
        } catch (JSONException e) {
            o.a("doDp3Report err", e);
            com.qq.gdt.action.g.a.a(ErrorCode.PrivateError.ERROR_INTERFACE_CALLED);
        }
    }

    public static void a(final List<com.qq.gdt.action.b.a> list, final a aVar) {
        if (f.a(list)) {
            o.b("No actions need to track.");
            return;
        }
        final long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            JSONObject jSONObjectA = com.qq.gdt.action.c.a();
            JSONArray jSONArrayA = com.qq.gdt.action.c.a(list);
            JSONObject jSONObject = new JSONObject();
            jSONObject.putOpt("info", jSONObjectA);
            jSONObject.putOpt("actions", jSONArrayA);
            o.a("TrackService#track\n加密前：\n" + n.a(jSONObject.toString()), new Object[0]);
            String strA = com.qq.gdt.action.c.a(jSONObject);
            o.a("加密后：\n" + strA, new Object[0]);
            String strA2 = com.qq.gdt.action.c.a(strA);
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.putOpt(t.c, "0.1");
            jSONObject2.putOpt("id", d.a().h());
            jSONObject2.putOpt("data", strA);
            jSONObject2.putOpt("sign", strA2);
            o.a("正式请求：\n" + n.a(jSONObject2.toString()), new Object[0]);
            final String strOptString = jSONObjectA.optString("hash_imei", "");
            com.qq.gdt.action.e.b.d().a("https://api.datanexus.qq.com/data-nexus-cgi/sdk").a(jSONObject2.toString().getBytes()).b().a(new com.qq.gdt.action.e.a.c() { // from class: com.qq.gdt.action.h.c.1
                @Override // com.qq.gdt.action.e.a.a
                public void a(int i, com.qq.gdt.action.e.f fVar) {
                    c.a(list, jCurrentTimeMillis, "https://api.datanexus.qq.com/data-nexus-cgi/sdk", fVar.a(), fVar.b(), i);
                    if (i == 200 && fVar.a() == 0) {
                        a aVar2 = aVar;
                        if (aVar2 != null) {
                            aVar2.a(list, !v.a(strOptString));
                            return;
                        }
                        return;
                    }
                    a aVar3 = aVar;
                    if (aVar3 != null) {
                        aVar3.a(list, fVar.a(), fVar.b(), i, fVar.c());
                    }
                }

                @Override // com.qq.gdt.action.e.a.a
                public void b(Throwable th) {
                    o.a("onFail:" + th.getMessage(), new Object[0]);
                    int i = -1;
                    if (th.getMessage() != null) {
                        i = th.getMessage().contains("java.net.SocketTimeoutException") ? -2 : -1;
                        if (th.getMessage().contains("java.net.UnknownHostException")) {
                            i = -9;
                        }
                        if (th.getMessage().contains("java.net.ConnectException")) {
                            i = -4;
                        }
                        if (th.getMessage().contains("java.net.ProtocolException")) {
                            i = -5;
                        }
                        if (th.getMessage().contains("java.net.UnknownServiceException")) {
                            i = -6;
                        }
                        if (th.getMessage().equals("body null")) {
                            i = -7;
                        }
                        if (th.getMessage().contains("unexpected end of stream on com.android.okhttp")) {
                            i = -8;
                        }
                    }
                    c.a(list, jCurrentTimeMillis, "https://api.datanexus.qq.com/data-nexus-cgi/sdk", i, th.getMessage(), -1);
                    a aVar2 = aVar;
                    if (aVar2 != null) {
                        aVar2.a(list, i, th.getMessage(), -1, "");
                    }
                }
            });
        } catch (Throwable th) {
            o.c("处理行为数据请求时发生错误：" + th.getMessage());
            if (aVar != null) {
                aVar.a(list, -1, th.getMessage(), -1, "");
            }
        }
    }
}
