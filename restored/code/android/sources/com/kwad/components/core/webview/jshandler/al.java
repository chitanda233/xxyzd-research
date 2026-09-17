package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import android.view.ViewGroup;
import android.webkit.WebView;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class al implements com.kwad.sdk.core.webview.c.a {
    private final WebView adg;
    private boolean aqO;
    private Handler aqf;
    private com.kwad.sdk.core.webview.c.c aqg;
    private b fh;

    public interface b {
        void a(a aVar);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "initKsAdFrame";
    }

    public al(com.kwad.sdk.core.webview.b bVar, b bVar2) {
        this(bVar, bVar2, true);
    }

    private al(com.kwad.sdk.core.webview.b bVar, b bVar2, boolean z) {
        this.aqO = true;
        this.aqf = new Handler(Looper.getMainLooper());
        this.adg = bVar.adg;
        this.fh = bVar2;
        this.aqO = true;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.aqg = cVar;
        try {
            JSONObject jSONObject = new JSONObject(str);
            final a aVar = new a();
            aVar.parseJson(jSONObject);
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.al.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (al.this.adg != null && al.this.aqO) {
                        ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) al.this.adg.getLayoutParams();
                        marginLayoutParams.width = -1;
                        marginLayoutParams.height = aVar.height;
                        marginLayoutParams.leftMargin = aVar.leftMargin;
                        marginLayoutParams.rightMargin = aVar.rightMargin;
                        marginLayoutParams.bottomMargin = aVar.bottomMargin;
                        al.this.adg.setLayoutParams(marginLayoutParams);
                    }
                    if (al.this.fh != null) {
                        al.this.fh.a(aVar);
                    }
                }
            });
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.al.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (al.this.aqg != null) {
                        al.this.aqg.b(null);
                    }
                }
            });
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            cVar.onError(-1, e.getMessage());
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.aqg = null;
        this.fh = null;
        this.aqf.removeCallbacksAndMessages(null);
    }

    public static final class a implements com.kwad.sdk.core.b {
        public int bottomMargin;
        public int height;
        public int leftMargin;
        public int rightMargin;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.height = jSONObject.optInt(MediaFormat.KEY_HEIGHT);
            this.leftMargin = jSONObject.optInt("leftMargin");
            this.rightMargin = jSONObject.optInt("rightMargin");
            this.bottomMargin = jSONObject.optInt("bottomMargin");
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediaFormat.KEY_HEIGHT, this.height);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "leftMargin", this.leftMargin);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "rightMargin", this.rightMargin);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "bottomMargin", this.bottomMargin);
            return jSONObject;
        }
    }
}
