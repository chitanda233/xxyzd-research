package com.kwad.sdk.a.a;

import android.R;
import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.text.TextUtils;
import android.view.View;
import android.widget.FrameLayout;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.y;
import com.kwad.sdk.wrapper.m;
import java.io.File;
import java.util.HashMap;
import java.util.Map;
import java.util.Stack;
import java.util.concurrent.TimeUnit;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private e aHe;
    private final Map<String, Integer> aHf;
    private final Map<String, Integer> aHg;
    private final Stack<AdTemplate> aHh;
    private volatile boolean aHi;
    public volatile boolean aHj;
    public volatile boolean aHk;

    static final class a {
        static final c aHp = new c(0);
    }

    /* synthetic */ c(byte b) {
        this();
    }

    static /* synthetic */ e a(c cVar, e eVar) {
        cVar.aHe = null;
        return null;
    }

    private c() {
        this.aHf = new HashMap();
        this.aHg = new HashMap();
        this.aHh = new Stack<>();
        this.aHi = false;
        this.aHj = false;
        this.aHk = false;
    }

    public static c Hx() {
        return a.aHp;
    }

    public final void bB(boolean z) {
        this.aHi = z;
    }

    public final AdTemplate Hy() {
        AdTemplate adTemplate = null;
        while (!this.aHh.isEmpty()) {
            AdTemplate adTemplatePop = this.aHh.pop();
            if (bq(adTemplatePop)) {
                adTemplate = adTemplatePop;
            }
        }
        if (adTemplate != null) {
            this.aHh.add(0, adTemplate);
        }
        return adTemplate;
    }

    private static boolean bq(AdTemplate adTemplate) {
        String strJ;
        if (adTemplate == null) {
            return false;
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (au.ax(ServiceProvider.getContext(), com.kwad.sdk.core.response.helper.a.aE(adInfoEM)) || (strJ = com.kwad.sdk.core.download.a.J(adInfoEM)) == null || TextUtils.isEmpty(strJ)) {
            return false;
        }
        return new File(strJ).exists();
    }

    public final void br(AdTemplate adTemplate) {
        if (bq(adTemplate)) {
            this.aHh.add(adTemplate);
        }
    }

    public final void bs(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return;
        }
        this.aHh.remove(adTemplate);
    }

    public final void bt(final AdTemplate adTemplate) {
        int iIntValue;
        int iJP = com.kwad.sdk.core.config.e.JP();
        if (adTemplate == null || iJP <= 0) {
            return;
        }
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (adTemplate.mAdScene.getAdStyle() == 0) {
            return;
        }
        String strValueOf = String.valueOf(com.kwad.sdk.core.response.helper.e.eW(adTemplate));
        if (this.aHf.containsKey(strValueOf)) {
            iIntValue = this.aHf.get(strValueOf).intValue();
            this.aHf.put(strValueOf, Integer.valueOf(iIntValue));
        } else {
            iIntValue = 0;
        }
        if (iIntValue > 0) {
            return;
        }
        i.schedule(new bi() { // from class: com.kwad.sdk.a.a.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (adInfoEM.status == 12 || adInfoEM.status == 10 || !y.hF(com.kwad.sdk.core.download.a.J(com.kwad.sdk.core.response.helper.e.eM(adTemplate)))) {
                    return;
                }
                c.this.f(adTemplate, true);
            }
        }, iJP, TimeUnit.SECONDS);
    }

    public final void bu(final AdTemplate adTemplate) {
        int iIntValue;
        int iKc = com.kwad.sdk.core.config.e.Kc();
        if (iKc < 0) {
            return;
        }
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        String strValueOf = String.valueOf(adInfoEM.adBaseInfo.creativeId);
        if (this.aHg.containsKey(strValueOf)) {
            iIntValue = this.aHg.get(strValueOf).intValue();
            this.aHg.put(strValueOf, Integer.valueOf(iIntValue));
        } else {
            iIntValue = 0;
        }
        if (iIntValue > 0) {
            return;
        }
        i.schedule(new Runnable() { // from class: com.kwad.sdk.a.a.c.2
            @Override // java.lang.Runnable
            public final void run() {
                if (au.ay(ServiceProvider.getContext(), com.kwad.sdk.core.response.helper.a.aE(adInfoEM)) == 1) {
                    return;
                }
                c.this.f(adTemplate, false);
            }
        }, iKc, TimeUnit.SECONDS);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void f(final AdTemplate adTemplate, final boolean z) {
        by.runOnUiThread(new bi() { // from class: com.kwad.sdk.a.a.c.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int iJQ = com.kwad.sdk.core.config.e.JQ();
                boolean z2 = z;
                if (!z2 || iJQ != 2) {
                    c.this.a(adTemplate, z2, iJQ, false);
                } else {
                    c.this.a(adTemplate, (DialogInterface.OnDismissListener) null, new DialogInterface.OnClickListener() { // from class: com.kwad.sdk.a.a.c.3.1
                        @Override // android.content.DialogInterface.OnClickListener
                        public final void onClick(DialogInterface dialogInterface, int i) {
                            if (i != -1) {
                                if (i == -2) {
                                    c cVar = c.this;
                                    c.j(adTemplate, 1);
                                    return;
                                }
                                return;
                            }
                            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                            bVar.dU(29);
                            bVar.eb(23);
                            com.kwad.sdk.core.adlog.c.e(adTemplate, null, bVar);
                            com.kwad.sdk.a.a.a.Hr();
                        }
                    });
                }
            }
        });
    }

    public final void Hz() {
        b.Hu().a(new b.a() { // from class: com.kwad.sdk.a.a.c.4
            @Override // com.kwad.sdk.a.a.b.a
            public final void hI() {
                by.runOnUiThreadDelay(new bi() { // from class: com.kwad.sdk.a.a.c.4.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (!c.this.aHi) {
                            c.this.HB();
                        } else {
                            c.this.aHk = true;
                        }
                    }
                }, com.kwad.sdk.core.config.e.JS());
            }

            @Override // com.kwad.sdk.a.a.b.a
            public final void Hw() {
                com.kwad.sdk.core.d.c.d("InstallTipsManager", "showInitDelayDialog failed");
            }
        });
    }

    public final void HA() {
        bB(false);
        if (this.aHj || !this.aHk) {
            return;
        }
        by.runOnUiThreadDelay(new bi() { // from class: com.kwad.sdk.a.a.c.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                c.this.HB();
            }
        }, 5000L);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void HB() {
        if (!this.aHj && com.kwad.sdk.a.a.a.b.dT() <= 0) {
            by.runOnUiThread(new Runnable() { // from class: com.kwad.sdk.a.a.c.6
                @Override // java.lang.Runnable
                public final void run() {
                    try {
                        AdTemplate adTemplateHv = b.Hu().Hv();
                        if (adTemplateHv == null || com.kwad.sdk.core.config.e.JR() == 0) {
                            return;
                        }
                        c.this.aHj = true;
                        com.kwad.sdk.core.c.b.Mh();
                        com.kwad.sdk.a.a.a.b.J(com.kwad.sdk.core.c.b.getCurrentActivity());
                        c.this.bv(adTemplateHv);
                    } catch (Throwable th) {
                        com.kwad.components.core.d.a.reportSdkCaughtException(th);
                    }
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bv(final AdTemplate adTemplate) {
        a(adTemplate, (DialogInterface.OnDismissListener) null, new DialogInterface.OnClickListener() { // from class: com.kwad.sdk.a.a.c.7
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i) {
                try {
                    if (i == -1) {
                        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                        bVar.dU(29);
                        bVar.eb(23);
                        com.kwad.sdk.core.adlog.c.e(adTemplate, null, bVar);
                        com.kwad.sdk.a.a.a.Hr();
                    } else {
                        if (i != -2) {
                            return;
                        }
                        c cVar = c.this;
                        c.j(adTemplate, 1);
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
        by.runOnUiThreadDelay(new bi() { // from class: com.kwad.sdk.a.a.c.8
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (com.kwad.sdk.a.a.a.Hr()) {
                    c cVar = c.this;
                    c.j(adTemplate, 2);
                }
            }
        }, 5000L);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void j(AdTemplate adTemplate, int i) {
        com.kwad.sdk.core.adlog.c.e(adTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(69).eb(23).ef(i));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(AdTemplate adTemplate, DialogInterface.OnDismissListener onDismissListener, DialogInterface.OnClickListener onClickListener) {
        if (com.kwad.sdk.a.a.a.pF()) {
            return;
        }
        com.kwad.sdk.core.c.b.Mh();
        Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
        if (currentActivity != null && com.kwad.sdk.a.a.a.a(currentActivity, adTemplate, onDismissListener, onClickListener)) {
            a(adTemplate, true, true);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:11:0x0011  */
    public void a(AdTemplate adTemplate, boolean z, int i, boolean z2) {
        boolean z3;
        if (this.aHe != null || com.kwad.components.core.e.c.b.pF()) {
            return;
        }
        if (z) {
            z3 = i == 1;
        }
        b(adTemplate, z, z3, z2);
    }

    private void b(final AdTemplate adTemplate, boolean z, boolean z2, boolean z3) {
        Context context;
        Context contextWrapContextIfNeed;
        com.kwad.sdk.core.c.b.Mh();
        Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
        if (currentActivity == null || (context = ((f) ServiceProvider.get(f.class)).getContext()) == null || (contextWrapContextIfNeed = m.wrapContextIfNeed(context)) == null) {
            return;
        }
        e eVar = new e(contextWrapContextIfNeed, adTemplate, z, z2, z3);
        View viewFindViewById = currentActivity.getWindow().getDecorView().findViewById(R.id.content);
        if (viewFindViewById instanceof FrameLayout) {
            eVar.b((FrameLayout) viewFindViewById);
            this.aHe = eVar;
            a(adTemplate, z, z3);
        }
        if (z3) {
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.a.a.a.b.J(com.kwad.sdk.core.c.b.getCurrentActivity());
            by.runOnUiThreadDelay(new bi() { // from class: com.kwad.sdk.a.a.c.9
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (c.this.aHe != null) {
                        c.this.aHe.dismiss();
                        c.a(c.this, (e) null);
                        c cVar = c.this;
                        c.j(adTemplate, 2);
                    }
                }
            }, 5000L);
        }
    }

    private void a(AdTemplate adTemplate, boolean z, boolean z2) {
        String strValueOf = String.valueOf(com.kwad.sdk.core.response.helper.e.eW(adTemplate));
        if (z) {
            b(this.aHf, strValueOf);
            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
            if (z2) {
                bVar.eb(23);
                bVar.dU(MediaPlayer.MEDIA_PLAYER_OPTION_SLOW_PLAY_SPEED);
            } else {
                bVar.dU(92);
            }
            com.kwad.sdk.core.adlog.c.d(adTemplate, (JSONObject) null, bVar);
            return;
        }
        com.kwad.sdk.core.adlog.c.c(adTemplate, 93, (JSONObject) null);
        b(this.aHg, strValueOf);
    }

    private static void b(Map<String, Integer> map, String str) {
        if (map.containsKey(str)) {
            map.put(str, Integer.valueOf(map.get(str).intValue() + 1));
        } else {
            map.put(str, 1);
        }
    }

    public final void HC() {
        this.aHe = null;
    }

    public final void dismiss() {
        com.kwad.sdk.a.a.a.Hr();
        e eVar = this.aHe;
        if (eVar != null) {
            eVar.dismiss();
            this.aHe = null;
        }
    }
}
