package com.kwad.components.core.innerEc.live.f;

import com.kwad.components.offline.api.core.utils.JsonHelper;
import com.kwad.sdk.core.d.c;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public String XD;
    public long XE;
    public String XF;
    public String XG;
    public Map<String, String> XH;
    public boolean XI;
    public boolean XJ;
    public String XK;
    public boolean XL;
    public long XM;
    public boolean XN;
    public String XO;
    public int action;

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public JSONObject toJson() {
        JSONObject json = super.toJson();
        if (this.XH != null) {
            try {
                JsonHelper.putValue(json, "throughInfo", new JSONObject(this.XH));
            } catch (Throwable th) {
                c.printStackTrace(th);
            }
        }
        return json;
    }
}
