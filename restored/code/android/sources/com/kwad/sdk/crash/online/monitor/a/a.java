package com.kwad.sdk.crash.online.monitor.a;

import android.text.TextUtils;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.core.response.a.a {
    public double aJX;
    public List<String> bfn = new ArrayList();
    public List<String> bfo = new ArrayList();
    public List<String> bfp = new ArrayList();
    public List<String> bfq = new ArrayList();
    public List<b> bfr = new ArrayList();
    public Map<String, b> bfs = new HashMap();
    public int bft;
    public int bfu;
    public int bfv;

    @Override // com.kwad.sdk.core.response.a.a
    public void afterParseJson(JSONObject jSONObject) {
        super.afterParseJson(jSONObject);
        List<b> list = this.bfr;
        if (list != null) {
            for (b bVar : list) {
                this.bfs.put(bVar.appId, bVar);
            }
            this.bfr.clear();
        }
    }

    public final boolean QL() {
        return (this.bfv & 4) != 0;
    }

    public final boolean QM() {
        return (this.bfv & 1) != 0;
    }

    public final boolean QN() {
        return (this.bfv & 2) != 0;
    }

    public final boolean QO() {
        return this.bfv == 0;
    }

    public final b gz(String str) {
        if (this.bfs == null) {
            return null;
        }
        b bVar = TextUtils.isEmpty(str) ? null : this.bfs.get(str);
        return bVar == null ? this.bfs.get("000000000") : bVar;
    }
}
