package com.kwad.sdk.collector.a;

import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.core.network.d;
import com.kwad.sdk.i;
import com.kwad.sdk.utils.ac;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends d {
    private C0497a aJj;

    public a(List<String> list) {
        C0497a c0497a = new C0497a(list);
        this.aJj = c0497a;
        putBody("targetAppInfo", c0497a.toJson());
        putBody("sdkVersion", BuildConfig.VERSION_NAME);
        putBody("sdkVersionCode", BuildConfig.VERSION_CODE);
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return i.Fg();
    }

    /* JADX INFO: renamed from: com.kwad.sdk.collector.a.a$a, reason: collision with other inner class name */
    static class C0497a {
        private List<String> aJk;

        public C0497a(List<String> list) {
            this.aJk = list;
        }

        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "packageName", this.aJk);
            return jSONObject;
        }
    }
}
