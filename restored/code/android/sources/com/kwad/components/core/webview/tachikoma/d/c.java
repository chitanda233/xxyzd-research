package com.kwad.components.core.webview.tachikoma.d;

import android.content.DialogInterface;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.z;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.core.webview.c.g;
import com.kwad.sdk.utils.bt;

/* JADX INFO: loaded from: classes3.dex */
public class c extends a {
    private String BV;
    private FrameLayout akZ;
    private e asz;
    private p auK;
    private az auL;
    private com.kwad.components.core.webview.tachikoma.f.e auM = new com.kwad.components.core.webview.tachikoma.f.e() { // from class: com.kwad.components.core.webview.tachikoma.d.c.2
        @Override // com.kwad.components.core.webview.tachikoma.f.e
        public final void hk() {
            if (c.this.auL != null) {
                c.this.auL.yJ();
                c.this.auL.yK();
            }
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.e
        public final void hs() {
            if (c.this.auL != null) {
                c.this.auL.yL();
                c.this.auL.yM();
            }
        }
    };

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getRegisterViewKey() {
        return null;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getTKReaderScene() {
        return "tk_dialog";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.akZ = (FrameLayout) findViewById(R.id.ksad_tk_dialog_container);
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        e eVar = this.asz;
        if (eVar != null) {
            eVar.a(this.auM);
        }
        if (this.auE.auG != null) {
            this.gg.a(new g() { // from class: com.kwad.components.core.webview.tachikoma.d.c.1
                @Override // com.kwad.sdk.core.webview.c.g
                public final void callTKBridge(String str) {
                    c.this.auE.auG.callTKBridge(str);
                }
            });
            this.auE.auG.a(this.gg);
            this.gg.a("hasTKBridge", Boolean.TRUE);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a
    protected final void a(b bVar) {
        super.a(bVar);
        this.BV = this.auE.BV;
        this.asz = this.auE.asz;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float height;
        float width;
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        FrameLayout frameLayout = this.akZ;
        if (frameLayout != null) {
            height = frameLayout.getHeight();
            width = this.akZ.getWidth();
        } else {
            height = 0.0f;
            width = 0.0f;
        }
        if (height == 0.0f || width == 0.0f) {
            aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
            aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
        } else {
            aVar.width = (int) ((width / fBA) + 0.5f);
            aVar.height = (int) ((height / fBA) + 0.5f);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
        this.auK = pVar;
        long j = this.auE.Cb;
        if (this.auK == null || j <= 0) {
            return;
        }
        z zVar = new z();
        zVar.ri = (int) ((j / 1000.0f) + 0.5f);
        this.auK.a(zVar);
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a, com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
        super.aC();
        if (this.auE.auI) {
            if (this.auE.akN != null) {
                this.auE.akN.H(true);
            }
        } else {
            e eVar = this.asz;
            if (eVar != null) {
                eVar.dismiss();
            }
            if (this.auE.akN != null) {
                this.auE.akN.ht();
            }
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.auL = azVar;
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
        super.a(uVar);
        e eVar = this.asz;
        if (eVar != null) {
            eVar.dismiss();
        }
        if (this.auE.akN != null) {
            this.auE.akN.H(true);
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.d.a, com.kwad.components.core.webview.tachikoma.j
    public void a(WebCloseStatus webCloseStatus) {
        super.a(webCloseStatus);
        if (this.auE.auG != null) {
            this.auE.auG.callbackDialogDismiss();
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getTkTemplateId() {
        if (this.auE.akP != null) {
            return this.auE.akP.templateId;
        }
        return this.BV;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public FrameLayout getTKContainer() {
        return this.akZ;
    }

    public void a(TKRenderFailReason tKRenderFailReason) {
        e eVar = this.asz;
        if (eVar != null) {
            if (eVar.isShowing()) {
                this.asz.d(new DialogInterface.OnDismissListener() { // from class: com.kwad.components.core.webview.tachikoma.d.c.3
                    @Override // android.content.DialogInterface.OnDismissListener
                    public final void onDismiss(DialogInterface dialogInterface) {
                        c.this.asz.e(this);
                        c.this.zJ();
                    }
                });
            } else {
                zJ();
            }
            this.asz.dismiss();
            return;
        }
        zJ();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void zJ() {
        if (this.auE.auJ != null) {
            this.auE.auJ.hm();
        }
        com.kwad.components.core.webview.tachikoma.e.c.zS().u(getTkTemplateId(), getTKReaderScene());
        if (this.auE.auG != null) {
            this.auE.auG.callbackPageStatus(false, "render failed");
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        if (this.auE.auG != null) {
            this.auE.auG.callbackPageStatus(true, null);
        }
    }
}
