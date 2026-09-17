package com.qq.gdt.action.e.a;

import com.byazt.nys.PluginConstants;
import com.qq.gdt.action.d;
import com.qq.gdt.action.e.b.i;
import com.qq.gdt.action.e.f;
import com.qq.gdt.action.i.o;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.io.IOException;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends a<f> {
    public c() {
        this(false);
    }

    public c(boolean z) {
        super(z);
    }

    @Override // com.qq.gdt.action.e.a.a
    /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
    public f b(i iVar) throws Exception {
        f fVar = new f(-1, "Unknown message", "");
        if (iVar != null) {
            try {
                JSONObject jSONObject = new JSONObject(iVar.e().b());
                fVar.a(jSONObject.optInt(PluginConstants.KEY_ERROR_CODE, -3));
                fVar.a(jSONObject.optString("message", "Deserialize message error"));
                fVar.b(jSONObject.optString(PointParamKey.TRACE_ID, ""));
                if (jSONObject.has("data")) {
                    JSONObject jSONObject2 = jSONObject.getJSONObject("data");
                    if (jSONObject2.has("conf")) {
                        com.qq.gdt.action.b.a(d.a().g()).a(jSONObject2.getJSONObject("conf"));
                    }
                }
            } catch (IOException | JSONException unused) {
                o.a("Deserialize service response error", new Object[0]);
                fVar.a(-3);
                fVar.a("Deserialize service response error");
            }
        }
        return fVar;
    }
}
