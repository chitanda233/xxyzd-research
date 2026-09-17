package com.kwad.components.ad.reward.presenter;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private static long ws;

    private static void o(final com.kwad.components.ad.reward.g gVar) {
        if (com.kwad.sdk.core.response.helper.a.cc(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate))) {
            p(gVar);
            return;
        }
        if (gVar.sI) {
            r(gVar);
            return;
        }
        gVar.sL = true;
        com.kwad.components.ad.reward.g.a(gVar.sy, new com.kwad.sdk.g.a<com.kwad.components.ad.reward.k.a>() { // from class: com.kwad.components.ad.reward.presenter.f.1
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(com.kwad.components.ad.reward.k.a aVar) {
                aVar.kf();
            }
        });
        gVar.sq.onVideoSkipToEnd(0L);
        com.kwad.sdk.core.adlog.c.i(gVar.mAdTemplate, gVar.mReportExtData);
        if (gVar.sr != null) {
            gVar.sr.release();
        }
        gVar.gU();
        u(gVar);
    }

    public static void a(final com.kwad.components.ad.reward.g gVar, boolean z) {
        AdTemplate adTemplate = gVar.mAdTemplate;
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (!gVar.sG) {
            o(gVar);
            return;
        }
        q(gVar);
        boolean z2 = !gVar.hg() && V(gVar.mAdTemplate);
        if (N(adTemplate) || O(adTemplate) || gVar.tf < com.kwad.sdk.core.response.helper.a.ak(adInfoEM)) {
            if (z2) {
                a(gVar, new com.kwad.components.ad.reward.h.b() { // from class: com.kwad.components.ad.reward.presenter.f.2
                    @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
                    public final void H(boolean z3) {
                        super.H(z3);
                        if (com.kwad.components.ad.reward.a.b.l(adInfoEM)) {
                            gVar.iK();
                        } else if (com.kwad.sdk.core.response.helper.a.cd(adInfoEM)) {
                            f.p(gVar);
                        } else {
                            f.r(gVar);
                            com.kwad.components.ad.reward.l.j(gVar);
                        }
                    }
                });
                return;
            } else if (com.kwad.sdk.core.response.helper.a.cd(adInfoEM)) {
                p(gVar);
                return;
            } else {
                r(gVar);
                com.kwad.components.ad.reward.l.j(gVar);
                return;
            }
        }
        if (gVar.sZ) {
            gVar.iK();
            return;
        }
        if (!gVar.tg && gVar.tf < com.kwad.sdk.core.response.helper.a.ak(adInfoEM)) {
            if (z) {
                gVar.iK();
                return;
            }
            return;
        }
        if (gVar.tg) {
            gVar.Z(2);
        } else {
            gVar.Z(1);
        }
        y(gVar);
        if (com.kwad.sdk.core.response.helper.a.cd(adInfoEM)) {
            p(gVar);
        } else {
            r(gVar);
            com.kwad.components.ad.reward.l.j(gVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void p(final com.kwad.components.ad.reward.g gVar) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.presenter.f.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                gVar.hh();
                gVar.sq.onVideoSkipToEnd(gVar.tf);
                gVar.release();
                gVar.iK();
            }
        });
    }

    private static boolean V(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.a.ao(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
    }

    private static void q(com.kwad.components.ad.reward.g gVar) {
        com.kwad.sdk.core.adlog.c.e(gVar.mAdTemplate, gVar.mReportExtData, new com.kwad.sdk.core.adlog.c.b().dU(69).dX(gVar.te != 0 ? (int) (gVar.te / 1000) : 0).dY(gVar.tf != 0 ? (int) (gVar.tf / 1000) : 0));
    }

    public static void r(final com.kwad.components.ad.reward.g gVar) {
        gVar.sL = true;
        gVar.hh();
        if (i.z(gVar)) {
            by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.f.4
                @Override // java.lang.Runnable
                public final void run() {
                    f.s(gVar);
                }
            }, 200L);
        } else {
            s(gVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void s(final com.kwad.components.ad.reward.g gVar) {
        com.kwad.components.ad.reward.g.a(gVar.sy, new com.kwad.sdk.g.a<com.kwad.components.ad.reward.k.a>() { // from class: com.kwad.components.ad.reward.presenter.f.5
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(com.kwad.components.ad.reward.k.a aVar) {
                aVar.kf();
            }
        });
        if (gVar.sr != null) {
            gVar.sr.skipToEnd();
        }
    }

    public static void t(com.kwad.components.ad.reward.g gVar) {
        x(gVar);
        gVar.iK();
    }

    public static void u(com.kwad.components.ad.reward.g gVar) {
        com.kwad.sdk.core.d.c.d("openAppMarket", "tryOpenAppMarket");
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (jElapsedRealtime - ws < 300) {
            com.kwad.sdk.core.d.c.d("openAppMarket", "连续点击");
            return;
        }
        ws = jElapsedRealtime;
        AdTemplate adTemplate = gVar.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (a(adInfoEM, "openAppMarket")) {
            return;
        }
        Context context = gVar.mContext;
        if (a("openAppMarket", adTemplate, adInfoEM)) {
            return;
        }
        com.kwad.sdk.core.adlog.c.b bVarEe = new com.kwad.sdk.core.adlog.c.b().dS(MediaPlayer.MEDIA_PLAYER_OPTION_SET_DEFAULT_CODEC_ID).ee(8);
        boolean z = com.kwad.sdk.core.download.a.b.I(context, com.kwad.sdk.core.response.helper.a.da(adInfoEM)) == 1;
        com.kwad.sdk.core.d.c.i("openAppMarket", "handleDeepLink dpSuccess: " + z);
        if (z) {
            com.kwad.components.ad.reward.j.b.a(adTemplate, "native_id", "autoLaunchMarket", bVarEe, (JSONObject) null);
            com.kwad.components.ad.reward.h.a.J(context);
            return;
        }
        String strDd = com.kwad.sdk.core.response.helper.a.dd(adInfoEM);
        com.kwad.sdk.core.d.c.i("openAppMarket", "tryOpenMiAppStore url：" + strDd);
        if (com.kwad.sdk.utils.f.a(context, strDd, adTemplate)) {
            com.kwad.components.ad.reward.j.b.a(adTemplate, "native_id", "autoLaunchMarket", bVarEe, (JSONObject) null);
            com.kwad.sdk.core.adlog.c.h(adTemplate, 1, 8);
            com.kwad.components.ad.reward.h.a.J(context);
        } else {
            if (com.kwad.sdk.utils.f.l(context, adTemplate)) {
                com.kwad.components.ad.reward.j.b.a(adTemplate, "native_id", "autoLaunchMarket", bVarEe, (JSONObject) null);
                com.kwad.sdk.core.adlog.c.h(adTemplate, 0, 8);
                com.kwad.components.ad.reward.h.a.J(context);
                return;
            }
            com.kwad.sdk.core.d.c.i("openAppMarket", "tryOpenMiAppStore failed");
        }
    }

    private static boolean a(String str, AdTemplate adTemplate, AdInfo adInfo) {
        if (com.kwad.sdk.core.response.helper.a.bQ(adInfo)) {
            com.kwad.sdk.core.d.c.i(str, "is playable return");
            return true;
        }
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
            com.kwad.sdk.core.d.c.i(str, "is not Download type");
            return true;
        }
        if (com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(adInfo))) {
            com.kwad.sdk.core.d.c.i(str, "isRewardLaunchAppTask");
            return true;
        }
        if (!com.kwad.components.ad.reward.g.g(adInfo)) {
            return false;
        }
        com.kwad.sdk.core.d.c.i(str, "is Aggregation return");
        return true;
    }

    private static boolean a(AdInfo adInfo, String str) {
        if (!com.kwad.components.ad.reward.a.b.hV()) {
            com.kwad.sdk.core.d.c.e(str, "isEnable false");
            return true;
        }
        if (TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.dd(adInfo))) {
            return true;
        }
        int iHU = com.kwad.components.ad.reward.a.b.hU();
        com.kwad.sdk.core.d.c.d(str, "JumpDirectMaxCount " + iHU);
        return iHU <= 0 || com.kwad.components.ad.reward.h.a.dT() >= iHU;
    }

    public static void v(com.kwad.components.ad.reward.g gVar) {
        AdTemplate adTemplate = gVar.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (!gVar.sG) {
            x(gVar);
            gVar.iK();
            return;
        }
        boolean z = true;
        if (N(adTemplate) || O(adTemplate)) {
            q(gVar);
            if ((gVar.hg() || !V(gVar.mAdTemplate) || gVar.sL) ? false : true) {
                w(gVar);
                return;
            } else {
                x(gVar);
                gVar.iK();
                return;
            }
        }
        long jAk = com.kwad.sdk.core.response.helper.a.ak(adInfoEM);
        if (!gVar.tg && gVar.tf < jAk) {
            z = false;
        }
        if (z) {
            y(gVar);
        }
        x(gVar);
        gVar.iK();
    }

    private static boolean N(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
    }

    private static boolean O(AdTemplate adTemplate) {
        return com.kwad.sdk.core.response.helper.e.O(adTemplate);
    }

    private static void w(final com.kwad.components.ad.reward.g gVar) {
        final AdTemplate adTemplate = gVar.mAdTemplate;
        com.kwad.components.ad.reward.g.a(gVar, com.kwad.components.ad.reward.h.a(gVar, (String) null), new com.kwad.components.ad.reward.h.b() { // from class: com.kwad.components.ad.reward.presenter.f.6
            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void hk() {
                gVar.F(true);
                com.kwad.sdk.core.adlog.c.b(adTemplate, 149, gVar.mReportExtData);
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void H(boolean z) {
                gVar.F(false);
                if (!z) {
                    com.kwad.sdk.core.adlog.c.s(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS);
                }
                f.x(gVar);
                gVar.iK();
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void ht() {
                gVar.F(false);
                com.kwad.sdk.core.adlog.c.s(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void x(com.kwad.components.ad.reward.g gVar) {
        gVar.sq.i(false);
    }

    private static void y(com.kwad.components.ad.reward.g gVar) {
        gVar.sq.onRewardVerify();
    }

    private static void a(final com.kwad.components.ad.reward.g gVar, final com.kwad.components.ad.reward.h.b bVar) {
        final AdTemplate adTemplate = gVar.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        final JSONObject jSONObject = gVar.mReportExtData;
        long jAg = com.kwad.sdk.core.response.helper.a.ag(adInfoEM);
        final com.kwad.components.ad.reward.h.c cVarA = com.kwad.components.ad.reward.h.a(gVar, (jAg <= 0 || ((long) com.kwad.sdk.core.response.helper.a.N(adInfoEM)) <= jAg) ? "观看完整视频即可获取奖励" : "观看视频" + jAg + "s即可获取奖励");
        com.kwad.components.ad.reward.g.a(gVar, cVarA, new com.kwad.components.ad.reward.h.b() { // from class: com.kwad.components.ad.reward.presenter.f.7
            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void hk() {
                if (gVar.sr != null) {
                    gVar.sr.pause();
                }
                gVar.F(true);
                if (cVarA.getStyle() == 0) {
                    com.kwad.sdk.core.adlog.c.j(adTemplate, jSONObject);
                } else {
                    com.kwad.sdk.core.adlog.c.b(adTemplate, 149, jSONObject);
                }
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void hs() {
                super.hs();
                gVar.F(false);
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void H(boolean z) {
                gVar.F(false);
                if (!z) {
                    com.kwad.sdk.core.adlog.c.s(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS);
                }
                com.kwad.components.ad.reward.h.b bVar2 = bVar;
                if (bVar2 != null) {
                    bVar2.H(z);
                }
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.core.webview.tachikoma.f.c
            public final void ht() {
                gVar.F(false);
                if (gVar.sr != null) {
                    gVar.sr.resume();
                }
                if (cVarA.getStyle() == 1 || cVarA.getStyle() == 2 || cVarA.getStyle() == 5 || cVarA.getStyle() == 8) {
                    com.kwad.sdk.core.adlog.c.s(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS);
                } else {
                    com.kwad.sdk.core.adlog.c.k(adTemplate, jSONObject);
                }
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.ad.reward.h.a
            public final void hr() {
                super.hr();
                com.kwad.sdk.core.adlog.c.s(adTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS);
                com.kwad.components.ad.reward.g gVar2 = gVar;
                gVar2.a(1, gVar2.mContext, 156, 1);
            }

            @Override // com.kwad.components.ad.reward.h.b, com.kwad.components.ad.reward.h.a
            public final void h(int i, int i2) {
                super.h(i, i2);
                com.kwad.components.ad.reward.g gVar2 = gVar;
                gVar2.a(1, gVar2.mContext, i, i2);
            }
        });
    }
}
