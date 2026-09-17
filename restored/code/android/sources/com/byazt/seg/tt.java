package com.byazt.seg;

import android.text.TextUtils;
import com.byazt.nr.m;
import com.kwad.components.offline.api.tk.model.report.TKDownloadReason;
import com.qq.gdt.action.ActionUtils;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 947, 13})
public class tt extends com.byazt.ku.c {
    public tt() {
    }

    public tt(com.byazt.ku.c cVar) {
        if (cVar != null) {
            c(cVar.tt());
            tt(cVar.ve());
            c(cVar.getResources());
        }
    }

    @Override // com.byazt.ku.c
    public boolean a() {
        return (TextUtils.isEmpty(ve()) || TextUtils.isEmpty(tt())) ? false : true;
    }

    @Override // com.byazt.ku.c
    public String x() {
        if (!a()) {
            return null;
        }
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.putOpt(com.alipay.sdk.m.n.c.e, tt());
            jSONObject.putOpt("version", ve());
            JSONArray jSONArray = new JSONArray();
            if (getResources() != null) {
                for (com.byazt.ku.c.C0174c c0174c : getResources()) {
                    if (c0174c != null) {
                        JSONObject jSONObject2 = new JSONObject();
                        jSONObject2.putOpt("url", c0174c.c());
                        jSONObject2.putOpt(TKDownloadReason.KSAD_TK_MD5, c0174c.tt());
                        jSONObject2.putOpt(ActionUtils.LEVEL, Integer.valueOf(c0174c.ve()));
                        jSONArray.put(jSONObject2);
                    }
                }
            }
            jSONObject.putOpt("resources", jSONArray);
            return jSONObject.toString();
        } catch (JSONException e) {
            m.c(e);
            return null;
        }
    }

    public static tt n(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        try {
            return tt(new JSONObject(str));
        } catch (JSONException e) {
            m.c(e);
            return null;
        }
    }

    public static tt tt(JSONObject jSONObject) {
        if (jSONObject == null) {
            return null;
        }
        tt ttVar = new tt();
        ttVar.c(jSONObject.optString(com.alipay.sdk.m.n.c.e));
        ttVar.tt(jSONObject.optString("version"));
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("resources");
        ArrayList arrayList = new ArrayList();
        if (jSONArrayOptJSONArray != null && jSONArrayOptJSONArray.length() > 0) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                JSONObject jSONObjectOptJSONObject = jSONArrayOptJSONArray.optJSONObject(i);
                if (jSONObjectOptJSONObject != null) {
                    com.byazt.ku.c.C0174c c0174c = new com.byazt.ku.c.C0174c();
                    c0174c.c(jSONObjectOptJSONObject.optString("url"));
                    c0174c.tt(jSONObjectOptJSONObject.optString(TKDownloadReason.KSAD_TK_MD5));
                    c0174c.c(jSONObjectOptJSONObject.optInt(ActionUtils.LEVEL));
                    arrayList.add(c0174c);
                }
            }
        }
        ttVar.c(arrayList);
        if (ttVar.a()) {
            return ttVar;
        }
        return null;
    }
}
