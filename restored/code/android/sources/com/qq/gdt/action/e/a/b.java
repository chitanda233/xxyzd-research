package com.qq.gdt.action.e.a;

import android.text.TextUtils;
import com.baidu.mobads.sdk.internal.cb;
import com.byazt.nys.PluginConstants;
import com.qq.gdt.action.e.b.i;
import com.qq.gdt.action.e.b.j;
import com.qq.gdt.action.i.o;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b extends a<com.qq.gdt.action.e.a> {
    public b() {
        super(false);
    }

    @Override // com.qq.gdt.action.e.a.a
    /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
    public com.qq.gdt.action.e.a b(i iVar) throws Exception {
        String strOptString = "Unknown message";
        com.qq.gdt.action.e.a aVar = new com.qq.gdt.action.e.a(-1, "Unknown message");
        if (iVar != null) {
            try {
                j jVarE = iVar.e();
                if (jVarE != null) {
                    String strB = jVarE.b();
                    if (!TextUtils.isEmpty(strB)) {
                        try {
                            JSONObject jSONObject = new JSONObject(strB);
                            if (jSONObject.has(PluginConstants.KEY_ERROR_CODE)) {
                                int iOptInt = jSONObject.optInt(PluginConstants.KEY_ERROR_CODE, -1);
                                aVar.b(iOptInt);
                                aVar.a(iOptInt);
                            } else if (jSONObject.has("ret")) {
                                int iOptInt2 = jSONObject.optInt("ret", -1);
                                aVar.a(iOptInt2);
                                aVar.b(iOptInt2);
                            }
                            if (jSONObject.has("msg")) {
                                strOptString = jSONObject.optString("msg", "Unknown message");
                            } else if (jSONObject.has("message")) {
                                strOptString = jSONObject.optString("message", "Unknown message");
                            }
                            aVar.a(strOptString);
                        } catch (JSONException unused) {
                            if (cb.o.equalsIgnoreCase(strB.trim()) || "ok".equalsIgnoreCase(strB.trim())) {
                                aVar.b(0);
                                aVar.a(0);
                            } else {
                                aVar.b(-1);
                                aVar.a(-1);
                            }
                            aVar.a(strB);
                        }
                    }
                }
            } catch (Exception e) {
                o.b("Dp3ResponseCallback 解析异常: " + e.getMessage(), e);
                throw e;
            }
        }
        return aVar;
    }
}
