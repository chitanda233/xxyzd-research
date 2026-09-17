package com.kwad.components.ad.reward.l.b;

import android.content.Context;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.au;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.l.a {
    private c Cq = new c();
    private C0395a Cr = new C0395a();
    private final b Cs = new b(com.kwad.components.ad.reward.a.b.hL());

    public static void a(a aVar, Context context, AdTemplate adTemplate) {
        if (au.ax(context, com.kwad.sdk.core.response.helper.a.aE(e.eM(adTemplate)))) {
            aVar.lh();
        } else {
            aVar.li();
        }
    }

    public final void le() {
        com.kwad.sdk.core.d.c.d("LaunchAppTask", "markWatchVideoCompleted");
        this.Cq.kW();
        lg();
    }

    public final void lh() {
        com.kwad.sdk.core.d.c.d("LaunchAppTask", "markInstallCompleted");
        this.Cr.kW();
        lg();
    }

    private void li() {
        com.kwad.sdk.core.d.c.d("LaunchAppTask", "markInstallUncompleted");
        this.Cr.kX();
        lg();
    }

    public final void lj() {
        com.kwad.sdk.core.d.c.d("LaunchAppTask", "markUseAppCompleted");
        this.Cs.kW();
        lg();
    }

    public final boolean lk() {
        com.kwad.sdk.core.d.c.d("LaunchAppTask", "isInstallCompleted");
        return this.Cr.isCompleted();
    }

    public final boolean lf() {
        return this.Cq.isCompleted();
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
        arrayList.add(this.Cq);
        arrayList.add(this.Cs);
        return arrayList;
    }

    private void lg() {
        if (this.Cq.isCompleted() && this.Cr.isCompleted() && this.Cs.isCompleted()) {
            kW();
        } else {
            kX();
        }
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.components.ad.reward.l.c
    public final boolean isCompleted() {
        return this.Cr.isCompleted() && this.Cs.isCompleted();
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.a(jSONObject, "mWatchVideoTask", this.Cq);
        ac.a(jSONObject, "mInstallAppTask", this.Cr);
        ac.a(jSONObject, "mUseAppTask", this.Cs);
        return jSONObject;
    }

    @Override // com.kwad.components.ad.reward.l.b, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        try {
            this.Cq.parseJson(jSONObject.optJSONObject("mWatchVideoTask"));
            this.Cs.parseJson(jSONObject.optJSONObject("mUseAppTask"));
        } catch (Throwable unused) {
        }
    }

    static class c extends com.kwad.components.ad.reward.l.b {
        public c() {
            this.Cm = "基础奖励：观看视频";
            this.Cn = "基础奖励：需再观看%ss视频";
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.reward.l.b.a$a, reason: collision with other inner class name */
    static class C0395a extends com.kwad.components.ad.reward.l.b {
        public C0395a() {
            this.Cm = "安装应用";
        }
    }

    static class b extends com.kwad.components.ad.reward.l.b {
        public b(int i) {
            this.Cm = String.format("进阶奖励：安装并激活APP %ss", new StringBuilder().append(i).toString());
            this.Cn = String.format("进阶奖励：安装并激活APP %ss", new StringBuilder().append(i).toString());
        }
    }
}
