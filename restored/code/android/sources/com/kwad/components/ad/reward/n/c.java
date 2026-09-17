package com.kwad.components.ad.reward.n;

import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.widget.KsAppTagsView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.KSRatingBar;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.sdk.core.download.a.a implements com.kwad.sdk.widget.d {
    private View CI;
    private View CJ;
    private Button CK;
    private Button CL;
    private TextView CM;
    private ImageView CN;
    private TextView CO;
    private TextView CP;
    private KSRatingBar CQ;
    private KsAppTagsView CR;
    private a CS;
    private volatile boolean CU = false;
    private com.kwad.components.ad.j.a CV;
    private Runnable CW;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    public interface a {
        void d(boolean z, int i);
    }

    @Override // com.kwad.sdk.core.download.a.a, com.kwad.sdk.api.KsAppDownloadListener
    public final void onDownloadStarted() {
    }

    public c(View view) {
        this.CI = view;
        initView();
        this.CV = new com.kwad.components.ad.j.a(view);
    }

    private void initView() {
        this.CK = (Button) this.CI.findViewById(R.id.ksad_reward_apk_info_install_action);
        this.CL = (Button) this.CI.findViewById(R.id.ksad_reward_apk_info_install_start);
        this.CJ = this.CI.findViewById(R.id.ksad_reward_apk_info_install_container);
        this.CN = (ImageView) this.CI.findViewById(R.id.ksad_reward_apk_info_icon);
        this.CM = (TextView) this.CI.findViewById(R.id.ksad_reward_apk_info_name);
        this.CO = (TextView) this.CI.findViewById(R.id.ksad_reward_apk_info_desc);
        this.CQ = (KSRatingBar) this.CI.findViewById(R.id.ksad_reward_apk_info_score);
        this.CR = (KsAppTagsView) this.CI.findViewById(R.id.ksad_reward_apk_info_tags);
    }

    public final void c(AdTemplate adTemplate, boolean z) {
        this.mAdTemplate = adTemplate;
        b bVarAb = b.ab(adTemplate);
        if (bVarAb == null) {
            return;
        }
        KSImageLoader.loadAppIcon(this.CN, bVarAb.tL, adTemplate, 12);
        this.CM.setText(bVarAb.appName);
        this.CO.setText(bVarAb.tM);
        this.CQ.setStar(bVarAb.CY);
        if (com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(adTemplate)))) {
            this.CL.setText(com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
            this.CQ.setVisibility(0);
        } else {
            this.CL.setText("查看详情");
            this.CQ.setVisibility(8);
        }
        this.CK.setText(bVarAb.lv());
        this.CK.setClickable(true);
        this.CL.setClickable(true);
        this.CJ.setClickable(true);
        new com.kwad.sdk.widget.h(this.CK, this);
        new com.kwad.sdk.widget.h(this.CL, this);
        new com.kwad.sdk.widget.h(this.CJ, this);
        List<String> list = bVarAb.CZ;
        if (z && list.size() == 0) {
            this.CO.setVisibility(8);
            TextView textView = (TextView) this.CI.findViewById(R.id.ksad_reward_apk_info_desc_2);
            this.CP = textView;
            textView.setVisibility(0);
            this.CP.setText(bVarAb.tM);
        }
        if (list.size() == 0) {
            this.CR.setVisibility(8);
        }
        this.CR.setAppTags(list);
        if (this.CW == null) {
            this.CW = new Runnable() { // from class: com.kwad.components.ad.reward.n.c.1
                @Override // java.lang.Runnable
                public final void run() {
                    com.kwad.sdk.core.d.c.d("ApkInfoCardViewHelper", hashCode() + " parentHeight: " + c.this.CJ.getHeight());
                    if (c.this.CU) {
                        return;
                    }
                    c.this.CV.jo();
                }
            };
        }
        this.CJ.postDelayed(this.CW, 1600L);
    }

    public final void a(com.kwad.components.core.e.d.d dVar) {
        this.mApkDownloadHelper = dVar;
        if (dVar != null) {
            dVar.b(this);
        }
    }

    public final void lt() {
        Runnable runnable;
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.c(this);
        }
        com.kwad.components.ad.j.a aVar = this.CV;
        if (aVar != null) {
            aVar.lt();
        }
        View view = this.CJ;
        if (view == null || (runnable = this.CW) == null) {
            return;
        }
        view.removeCallbacks(runnable);
        this.CW = null;
    }

    public final void lu() {
        this.CV.oi();
    }

    public final void a(a aVar) {
        this.CS = aVar;
    }

    public final void j(String str, int i) {
        Button button = this.CL;
        if (button == null || str == null || i == 0) {
            return;
        }
        button.setText(str);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        e(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mAdTemplate, f, f2, f3, f4)) {
            e(view, false);
        }
    }

    private void e(View view, boolean z) {
        int id = view.getId();
        if (id == R.id.ksad_reward_apk_info_install_container || id == R.id.ksad_reward_apk_info_install_action || id == R.id.ksad_reward_apk_info_install_start) {
            com.kwad.sdk.core.d.c.d("ApkInfoCardViewHelper", "onClick install");
            this.CU = true;
            a aVar = this.CS;
            if (aVar != null) {
                aVar.d(z, 1);
            }
        }
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public final void onIdle() {
        AdTemplate adTemplate = this.mAdTemplate;
        this.CL.setText(adTemplate != null ? com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即下载");
    }

    @Override // com.kwad.sdk.core.download.a.a
    public final void onPaused(int i) {
        super.onPaused(i);
        if (i != 0) {
            this.CV.oi();
            this.CL.setText(com.kwad.sdk.core.response.helper.a.ew(i));
        }
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public final void onProgressUpdate(int i) {
        if (i != 0) {
            this.CV.oi();
            this.CL.setText(com.kwad.sdk.core.response.helper.a.ev(i));
        }
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public final void onDownloadFinished() {
        AdTemplate adTemplate = this.mAdTemplate;
        this.CL.setText(adTemplate == null ? "" : com.kwad.sdk.core.response.helper.a.cF(adTemplate));
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public final void onInstalled() {
        AdTemplate adTemplate = this.mAdTemplate;
        this.CL.setText(adTemplate != null ? com.kwad.sdk.core.response.helper.a.af(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即打开");
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public final void onDownloadFailed() {
        AdTemplate adTemplate = this.mAdTemplate;
        this.CL.setText(adTemplate != null ? com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即下载");
    }

    static class b {
        private float CY;
        private List<String> CZ;
        private int Da = 15;
        private String Db;
        private String appName;
        private String tL;
        private String tM;

        b() {
        }

        public static b ab(AdTemplate adTemplate) {
            if (adTemplate == null) {
                return null;
            }
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            b bVar = new b();
            if (com.kwad.sdk.core.response.helper.e.O(adTemplate)) {
                bVar.appName = com.kwad.sdk.core.response.helper.a.aD(adInfoEM);
            } else {
                bVar.appName = com.kwad.sdk.core.response.helper.a.aB(adInfoEM);
            }
            bVar.CY = com.kwad.sdk.core.response.helper.a.aI(adInfoEM);
            bVar.tM = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
            if (com.kwad.sdk.core.response.helper.e.O(adTemplate)) {
                bVar.tL = com.kwad.sdk.core.response.helper.a.cV(adInfoEM);
            } else {
                bVar.tL = com.kwad.sdk.core.response.helper.a.cv(adInfoEM);
            }
            if (com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(adTemplate)))) {
                bVar.Da = com.kwad.components.ad.reward.a.b.hL();
                bVar.Db = "安装并体验%s秒  可领取奖励";
            } else {
                bVar.Da = com.kwad.sdk.core.config.e.Kj();
                bVar.Db = "浏览详情页%s秒，领取奖励";
            }
            bVar.CZ = com.kwad.sdk.core.response.helper.d.eD(adTemplate);
            return bVar;
        }

        public final String lv() {
            return String.format(this.Db, Integer.valueOf(this.Da));
        }
    }
}
