package com.kwad.components.core.webview.tachikoma;

import android.app.Activity;
import android.content.Context;
import android.text.TextUtils;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.offline.api.tk.model.BundleServiceConfig;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.sdk.api.KsAdSDK;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private final Map<String, a> ask = new ConcurrentHashMap();

    public interface b {
        void onFailed(String str);

        void onSuccess();
    }

    static class c {
        private static final g ast = new g();
    }

    public static g yT() {
        return c.ast;
    }

    public final void init() {
        try {
            com.kwad.components.core.offline.a.f.b bVar = (com.kwad.components.core.offline.a.f.b) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.f.b.class);
            if (bVar != null) {
                bVar.a(new com.kwad.components.core.offline.a.f.a() { // from class: com.kwad.components.core.webview.tachikoma.g.1
                    @Override // com.kwad.components.core.offline.a.f.a
                    public final void a(int i, int i2, long j, long j2) {
                        g.this.aT(KsAdSDK.getContext());
                    }
                });
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aT(Context context) {
        JSONObject jSONObjectOptJSONObject;
        JSONArray jSONArrayOptJSONArray;
        com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "begin load all services");
        SdkConfigData sdkConfigDataKd = com.kwad.sdk.core.config.e.Kd();
        if (context == null || (jSONObjectOptJSONObject = sdkConfigDataKd.toJson().optJSONObject("appConfig")) == null || (jSONArrayOptJSONArray = jSONObjectOptJSONObject.optJSONArray("tkServiceConfigs")) == null) {
            return;
        }
        for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
            BundleServiceConfig bundleServiceConfig = new BundleServiceConfig();
            bundleServiceConfig.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
            if (bundleServiceConfig.loadType == 1) {
                b(context, bundleServiceConfig.bundleName, null);
            }
        }
    }

    public final void a(Context context, String str, b bVar) {
        if (TextUtils.isEmpty(str)) {
            bVar.onFailed("invalid bundle string");
            return;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            StyleTemplate styleTemplate = new StyleTemplate();
            styleTemplate.parseJson(jSONObject);
            if (TextUtils.isEmpty(styleTemplate.templateId) || TextUtils.isEmpty(styleTemplate.templateUrl)) {
                bVar.onFailed("invalid bundle:" + str);
            }
            a(context, styleTemplate, bVar);
        } catch (Throwable th) {
            bVar.onFailed(th.getMessage());
        }
    }

    public final void b(Context context, String str, b bVar) {
        if (isLocalDebugEnable()) {
            unloadBundle(str);
        }
        com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle:" + str);
        if (TextUtils.isEmpty(str)) {
            com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle fail: invalid bundle name");
            if (bVar != null) {
                bVar.onFailed("invalid bundle name");
                return;
            }
            return;
        }
        SdkConfigData sdkConfigDataKd = com.kwad.sdk.core.config.e.Kd();
        if (sdkConfigDataKd == null) {
            com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle fail: config data empty");
            if (bVar != null) {
                bVar.onFailed("config data empty");
                return;
            }
            return;
        }
        if (context == null) {
            com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle fail: no context");
            if (bVar != null) {
                bVar.onFailed("no context");
                return;
            }
            return;
        }
        JSONObject jSONObjectOptJSONObject = sdkConfigDataKd.toJson().optJSONObject("styleTemplatesConfig");
        StyleTemplate styleTemplate = null;
        JSONArray jSONArrayOptJSONArray = jSONObjectOptJSONObject == null ? null : jSONObjectOptJSONObject.optJSONArray("styleTemplates");
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                StyleTemplate styleTemplate2 = new StyleTemplate();
                styleTemplate2.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                if (styleTemplate2.templateId != null && styleTemplate2.templateId.equals(str)) {
                    styleTemplate = styleTemplate2;
                    break;
                }
            }
        }
        if (isLocalDebugEnable() && styleTemplate == null) {
            styleTemplate = new StyleTemplate();
            styleTemplate.templateId = str;
        }
        if (styleTemplate == null) {
            com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle fail: no bundle");
            if (bVar != null) {
                bVar.onFailed("no bundle");
                return;
            }
            return;
        }
        a(context, styleTemplate, bVar);
    }

    private void a(Context context, final StyleTemplate styleTemplate, b bVar) {
        final String str = styleTemplate.templateId;
        if (str == null) {
            if (bVar != null) {
                bVar.onFailed("no bundle");
                return;
            }
            return;
        }
        a aVar = this.ask.get(str);
        if (aVar != null) {
            if (aVar.VK) {
                com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle finish: already load");
                if (bVar != null) {
                    bVar.onSuccess();
                    return;
                }
                return;
            }
            aVar.a(bVar);
            return;
        }
        i iVar = new i(context, false);
        iVar.a("isService", Boolean.TRUE);
        final a aVar2 = new a(iVar);
        aVar2.a(bVar);
        iVar.a(styleTemplate);
        iVar.a((Activity) null, (AdResultData) null, new j() { // from class: com.kwad.components.core.webview.tachikoma.g.2
            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(ae.a aVar3) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(az azVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(o oVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(p pVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(n nVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(u uVar) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(WebCloseStatus webCloseStatus) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(t tVar, com.kwad.sdk.core.webview.b bVar2) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar3) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aC() {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aD() {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void f(AdTemplate adTemplate) {
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getRegisterViewKey() {
                return null;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final FrameLayout getTKContainer() {
                return null;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getTKReaderScene() {
                return "tk_bundle_service";
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final com.kwad.sdk.widget.g getTouchCoordsView() {
                return null;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final String getTkTemplateId() {
                return styleTemplate.templateId;
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void a(TKRenderFailReason tKRenderFailReason) {
                com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle fail: execute fail");
                aVar2.bG("execute fail");
                g.this.unloadBundle(str);
            }

            @Override // com.kwad.components.core.webview.tachikoma.j
            public final void aB() {
                com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "load bundle success: done");
                aVar2.VK = true;
                aVar2.yU();
            }
        });
        this.ask.put(str, aVar2);
    }

    public final void unloadBundle(String str) {
        if (this.ask.get(str) != null) {
            com.kwad.sdk.core.d.c.d("KSAdTKBundleService", "unload bundle" + str);
            a aVar = this.ask.get(str);
            if (aVar != null) {
                aVar.asp.kT();
            }
            this.ask.remove(str);
        }
    }

    static class a {
        public boolean VK;
        public i asp;
        public List<b> asq = new ArrayList();

        a(i iVar) {
            this.asp = iVar;
        }

        public final void a(b bVar) {
            if (bVar != null) {
                this.asq.add(bVar);
            }
        }

        public final void bG(final String str) {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.g.a.1
                @Override // java.lang.Runnable
                public final void run() {
                    Iterator<b> it = a.this.asq.iterator();
                    while (it.hasNext()) {
                        it.next().onFailed(str);
                    }
                    a.this.asq.clear();
                }
            });
        }

        public final void yU() {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.g.a.2
                @Override // java.lang.Runnable
                public final void run() {
                    Iterator<b> it = a.this.asq.iterator();
                    while (it.hasNext()) {
                        it.next().onSuccess();
                    }
                    a.this.asq.clear();
                }
            });
        }
    }

    private static boolean isLocalDebugEnable() {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return false;
    }
}
