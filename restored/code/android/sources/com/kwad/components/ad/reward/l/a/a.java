package com.kwad.components.ad.reward.l.a;

import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ac;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.l.a {
    private b Co = new b();
    private final C0394a Cp = new C0394a(e.Kj());

    public final void le() {
        c.d("LandPageOpenTask", "markWatchVideoCompleted");
        this.Co.kW();
        lg();
    }

    public final void markOpenNsCompleted() {
        c.d("LandPageOpenTask", "markOpenNsCompleted");
        this.Cp.kW();
        lg();
    }

    public final boolean lf() {
        return this.Co.isCompleted();
    }

    @Override // com.kwad.components.ad.reward.l.a
    public final int kV() {
        Iterator<com.kwad.components.ad.reward.l.c> it = kU().iterator();
        int i = 0;
        while (it.hasNext()) {
            if (!it.next().isCompleted()) {
                i++;
            }
        }
        return i;
    }

    @Override // com.kwad.components.ad.reward.l.a
    public final List<com.kwad.components.ad.reward.l.c> kU() {
        ArrayList arrayList = new ArrayList();
        arrayList.add(this.Co);
        arrayList.add(this.Cp);
        return arrayList;
    }

    private void lg() {
        if (this.Cp.isCompleted()) {
            kW();
        } else {
            kX();
        }
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.components.ad.reward.l.c
    public final boolean isCompleted() {
        return this.Cp.isCompleted();
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.a(jSONObject, "mWatchVideoTask", this.Co);
        ac.a(jSONObject, "mOpenNsTask", this.Cp);
        return jSONObject;
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        try {
            this.Co.parseJson(jSONObject.optJSONObject("mWatchVideoTask"));
            this.Cp.parseJson(jSONObject.optJSONObject("mOpenNsTask"));
        } catch (Throwable unused) {
        }
    }

    static class b extends com.kwad.components.ad.reward.l.b {
        public b() {
            this.Cm = "基础奖励：观看视频";
            this.Cn = "基础奖励：需再观看%ss视频";
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.reward.l.a.a$a, reason: collision with other inner class name */
    static class C0394a extends com.kwad.components.ad.reward.l.b {
        public C0394a(int i) {
            this.Cm = String.format("进阶奖励：浏览详情页 %ss", new StringBuilder().append(i).toString());
            this.Cn = String.format("进阶奖励：浏览详情页 %ss", new StringBuilder().append(i).toString());
        }
    }
}
