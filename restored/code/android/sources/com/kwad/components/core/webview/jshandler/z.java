package com.kwad.components.core.webview.jshandler;

import android.content.DialogInterface;
import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class z implements com.kwad.sdk.core.webview.c.a {
    private DialogInterface.OnDismissListener Ck;
    protected final com.kwad.sdk.core.webview.b apL;
    private int apW;
    private boolean apX;
    private final boolean apY;
    private boolean apZ;
    private List<com.kwad.components.core.e.d.d> aqa;
    private boolean aqb;
    private com.kwad.sdk.core.webview.d.a.a fg;

    protected void Y(int i) {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "clickAction";
    }

    protected void kL() {
    }

    static /* synthetic */ boolean a(z zVar, com.kwad.sdk.core.webview.d.b.a aVar) {
        return b(aVar);
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, boolean z, int i, boolean z2, boolean z3) {
        this.apX = false;
        this.aqa = new ArrayList();
        this.apX = z;
        this.apL = bVar;
        this.apW = i;
        if (dVar != null) {
            dVar.aI(1);
            this.aqa.add(dVar);
        }
        this.fg = aVar;
        this.apY = z2;
        this.aqb = z3;
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, DialogInterface.OnDismissListener onDismissListener) {
        this(bVar, dVar, aVar, false, 0, false, false);
        this.Ck = onDismissListener;
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar) {
        this(bVar, dVar, aVar, false, 0, false, false);
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, boolean z) {
        this(bVar, dVar, aVar, false, 0, false, false);
        this.apZ = true;
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, int i, boolean z) {
        this(bVar, dVar, null, false, 2, z, false);
    }

    public z(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, int i) {
        this(bVar, dVar, aVar, false, 1, false, false);
    }

    public z(com.kwad.sdk.core.webview.b bVar, List<com.kwad.components.core.e.d.d> list, com.kwad.sdk.core.webview.d.a.a aVar) {
        this(bVar, null, aVar, false, 0, false, false);
        if (list != null) {
            this.aqa.addAll(list);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        final com.kwad.sdk.core.webview.d.b.a aVar = new com.kwad.sdk.core.webview.d.b.a();
        try {
            aVar.parseJson(new JSONObject(str));
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
        if (this.apL.PE() && aVar.adTemplate == null) {
            cVar.onError(-1, "native adTemplate is null");
            return;
        }
        if (this.apL.bbX && !aVar.bdi) {
            by.runOnUiThread(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.z.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    AdTemplate adTemplate;
                    String strY;
                    if (z.this.apL.bbY) {
                        if (aVar.adTemplate != null) {
                            adTemplate = aVar.adTemplate;
                            z.this.aqa.add(new com.kwad.components.core.e.d.d(adTemplate));
                        } else if (aVar.creativeId >= 0) {
                            adTemplate = com.kwad.sdk.core.response.helper.e.a(z.this.apL.PD(), aVar.creativeId, aVar.adStyle);
                        } else {
                            adTemplate = z.this.apL.getAdTemplate();
                            aVar.creativeId = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
                            aVar.adStyle = com.kwad.sdk.core.response.helper.e.eH(adTemplate);
                        }
                        com.kwad.components.core.e.d.d dVarT = z.this.T(aVar.creativeId);
                        if (z.this.Ck != null && dVarT != null) {
                            dVarT.setOnDismissListener(z.this.Ck);
                        }
                        if (!TextUtils.isEmpty(aVar.Rc)) {
                            try {
                                strY = com.kwad.components.core.e.b.a.y(Long.parseLong(aVar.Rc));
                            } catch (Exception unused) {
                                strY = aVar.Rc;
                            }
                        } else {
                            strY = (adTemplate == null || adTemplate.tkLiveShopItemInfo == null) ? null : adTemplate.tkLiveShopItemInfo.itemId;
                        }
                        z.this.Y(com.kwad.components.core.e.d.a.a(z.this.a(new com.kwad.components.core.e.d.a.C0428a(z.this.apL.adZ.getContext()).aF(adTemplate).b(dVarT).an(strY).as(z.a(z.this, aVar)).at(z.this.apX).d(z.this.apL.mReportExtData).aD(aVar.arc).aB(aVar.bdh).aC(aVar.ne).au(z.this.apY || aVar.needReport).aH(z.this.apW).ap(z.this.aqb).aw(z.this.apZ).aA(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.core.webview.jshandler.z.1.1
                            @Override // com.kwad.components.core.e.d.a.b
                            public final void onAdClicked() {
                                z.this.kL();
                                if (z.this.fg == null || aVar.bdj) {
                                    return;
                                }
                                z.this.fg.a(aVar);
                            }
                        }), aVar, adTemplate)));
                    }
                }
            });
        } else if (this.fg != null) {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.jshandler.z.2
                @Override // java.lang.Runnable
                public final void run() {
                    if (z.this.fg == null || aVar.bdj) {
                        return;
                    }
                    z.this.fg.a(aVar);
                }
            });
        }
        cVar.b(null);
    }

    protected com.kwad.components.core.e.d.a.C0428a a(com.kwad.components.core.e.d.a.C0428a c0428a, com.kwad.sdk.core.webview.d.b.a aVar, AdTemplate adTemplate) {
        if (aVar.ard != null && !TextUtils.isEmpty(aVar.ard.QQ)) {
            c0428a.ao(aVar.ard.QQ);
        }
        if (aVar.ard != null && aVar.ard.convertType != 0) {
            c0428a.aF(aVar.ard.convertType);
        }
        if (com.kwad.sdk.core.response.helper.e.ff(adTemplate) && aVar.ard != null && aVar.ard.bdk != null) {
            com.kwad.sdk.utils.al.a aVar2 = new com.kwad.sdk.utils.al.a();
            aVar2.k((float) aVar.ard.bdk.x, (float) aVar.ard.bdk.y);
            aVar2.j((float) aVar.ard.bdk.x, (float) aVar.ard.bdk.y);
            aVar2.H(aVar.ard.bdk.width, aVar.ard.bdk.height);
            c0428a.d(aVar2);
        } else {
            com.kwad.sdk.widget.g gVar = this.apL.bbV;
            if (gVar != null) {
                c0428a.d(gVar.getTouchCoords());
            }
        }
        c0428a.a(null, null, null);
        return c0428a;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.fg = null;
    }

    protected final com.kwad.components.core.e.d.d T(long j) {
        List<com.kwad.components.core.e.d.d> list = this.aqa;
        if (list == null) {
            return null;
        }
        if (j < 0 && list.size() == 1) {
            return this.aqa.get(0);
        }
        for (com.kwad.components.core.e.d.d dVar : this.aqa) {
            if (com.kwad.sdk.core.response.helper.e.eW(dVar.qs()) == j) {
                return dVar;
            }
        }
        return null;
    }

    private static boolean b(com.kwad.sdk.core.webview.d.b.a aVar) {
        return aVar.arc == 1;
    }
}
