package com.kwad.components.core.webview.tachikoma.a;

import android.content.DialogInterface;
import android.text.TextUtils;
import com.kwad.sdk.components.m;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements m {
    private DialogInterface.OnDismissListener Ck;
    protected final com.kwad.sdk.core.webview.b apL;
    private int apW;
    private boolean apX;
    private final boolean apY;
    private boolean apZ;
    private List<com.kwad.components.core.e.d.d> aqa;
    private boolean aqb;
    private com.kwad.sdk.core.webview.d.a.a fg;

    static /* synthetic */ boolean a(a aVar, com.kwad.sdk.core.webview.d.b.a aVar2) {
        return b(aVar2);
    }

    private a(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, boolean z, int i, boolean z2, boolean z3) {
        this.apX = false;
        this.aqa = new ArrayList();
        this.apX = false;
        this.apL = bVar;
        this.apW = 0;
        if (dVar != null) {
            dVar.aI(1);
            this.aqa.add(dVar);
        }
        this.fg = aVar;
        this.apY = false;
        this.aqb = false;
    }

    public a(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, boolean z) {
        this(bVar, dVar, aVar, false, 0, false, false);
        this.apZ = true;
    }

    @Override // com.kwad.sdk.components.m
    public final Object call(Object... objArr) {
        final com.kwad.sdk.core.webview.d.b.a aVar = new com.kwad.sdk.core.webview.d.b.a();
        if (objArr != null) {
            try {
                if (objArr.length > 0) {
                    Object obj = objArr[0];
                    if (obj instanceof String) {
                        aVar.parseJson(new JSONObject((String) obj));
                    }
                }
            } catch (JSONException e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        if (this.apL.PE() && aVar.adTemplate == null) {
            return null;
        }
        if (this.apL.bbX && !aVar.bdi) {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.a.a.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    AdTemplate adTemplate;
                    String strY;
                    if (a.this.apL.bbY) {
                        if (aVar.adTemplate != null) {
                            adTemplate = aVar.adTemplate;
                            a.this.aqa.add(new com.kwad.components.core.e.d.d(adTemplate));
                        } else if (aVar.creativeId >= 0) {
                            adTemplate = com.kwad.sdk.core.response.helper.e.a(a.this.apL.PD(), aVar.creativeId, aVar.adStyle);
                        } else {
                            adTemplate = a.this.apL.getAdTemplate();
                            aVar.creativeId = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
                            aVar.adStyle = com.kwad.sdk.core.response.helper.e.eH(adTemplate);
                        }
                        com.kwad.components.core.e.d.d dVarT = a.this.T(aVar.creativeId);
                        if (a.this.Ck != null && dVarT != null) {
                            dVarT.setOnDismissListener(a.this.Ck);
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
                        com.kwad.components.core.e.d.a.a(a.this.a(new com.kwad.components.core.e.d.a.C0428a(a.this.apL.adZ.getContext()).aF(adTemplate).b(dVarT).an(strY).as(a.a(a.this, aVar)).at(a.this.apX).d(a.this.apL.mReportExtData).aD(aVar.arc).aB(aVar.bdh).aC(aVar.ne).au(a.this.apY || aVar.needReport).aH(a.this.apW).ap(a.this.aqb).aw(a.this.apZ).aA(true).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.core.webview.tachikoma.a.a.1.1
                            @Override // com.kwad.components.core.e.d.a.b
                            public final void onAdClicked() {
                                if (a.this.fg == null || aVar.bdj) {
                                    return;
                                }
                                a.this.fg.a(aVar);
                            }
                        }), aVar, adTemplate));
                    }
                }
            });
        } else if (this.fg != null) {
            by.postOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.tachikoma.a.a.2
                @Override // java.lang.Runnable
                public final void run() {
                    if (a.this.fg == null || aVar.bdj) {
                        return;
                    }
                    a.this.fg.a(aVar);
                }
            });
        }
        return null;
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

    protected final com.kwad.components.core.e.d.a.C0428a a(com.kwad.components.core.e.d.a.C0428a c0428a, com.kwad.sdk.core.webview.d.b.a aVar, AdTemplate adTemplate) {
        if (aVar.ard != null && !TextUtils.isEmpty(aVar.ard.QQ)) {
            c0428a.ao(aVar.ard.QQ);
        }
        if (aVar.ard != null && aVar.ard.convertType != 0) {
            c0428a.aF(aVar.ard.convertType);
        }
        if (com.kwad.sdk.core.response.helper.e.ff(adTemplate) && aVar.ard != null && aVar.ard.bdk != null) {
            al.a aVar2 = new al.a();
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
}
