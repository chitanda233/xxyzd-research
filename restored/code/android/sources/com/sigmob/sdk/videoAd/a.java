package com.sigmob.sdk.videoAd;

import android.content.Context;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.wire.Wire;
import com.sigmob.sdk.base.common.n;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.config.SigmobDialogSetting;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.RvAdSetting;
import com.sigmob.sdk.base.o;
import java.io.Serializable;

/* JADX INFO: loaded from: classes4.dex */
public class a extends com.sigmob.sdk.base.common.i implements Serializable {
    private static final long serialVersionUID = 2;
    private int r;
    private c t;
    private int u;
    private boolean v;
    protected float m = 1.0f;
    protected int n = -1000;
    protected int o = 100;
    protected boolean p = false;
    private int q = -1;
    private boolean s = false;
    protected boolean l = false;

    private a() {
    }

    private void c(final boolean isRewardedVideo) {
        this.l = isRewardedVideo;
    }

    public static a d(BaseAdUnit adUnit) {
        a aVar = new a();
        aVar.c(adUnit.getAd_type() == 1);
        aVar.d(adUnit.getMaterial().video_reciprocal_millisecond.intValue());
        aVar.b(adUnit.getMaterial().creative_type.intValue() != n.CreativeTypeVideo_transparent_html.a());
        RvAdSetting rvAdSetting = adUnit.getRvAdSetting();
        SigmobDialogSetting sigmobDialogSettingW = o.a().w();
        aVar.a(sigmobDialogSettingW != null ? new c((String) Wire.get(sigmobDialogSettingW.title, ""), (String) Wire.get(sigmobDialogSettingW.body_text, ""), (String) Wire.get(sigmobDialogSettingW.cancel_button_text, ""), (String) Wire.get(sigmobDialogSettingW.close_button_text, "")) : new c(com.sigmob.sdk.base.k.l(), com.sigmob.sdk.base.k.k(), com.sigmob.sdk.base.k.n(), com.sigmob.sdk.base.k.m()));
        if (rvAdSetting != null) {
            aVar.a(rvAdSetting.enable_exit_on_video_close.booleanValue());
            aVar.a(rvAdSetting.finished.floatValue());
            aVar.c(rvAdSetting.end_time.intValue());
        }
        aVar.b(adUnit);
        return aVar;
    }

    public static f e(final BaseAdUnit adUnit) {
        if (adUnit == null) {
            return null;
        }
        MaterialMeta material = adUnit.getMaterial();
        com.sigmob.sdk.base.views.n.a aVar = material.click_type.intValue() == 2 ? com.sigmob.sdk.base.views.n.a.IMAGE : com.sigmob.sdk.base.views.n.a.JAVASCRIPT;
        return new f(768, 1024, adUnit.getInteractionType(), material.landing_page, material.deeplink_url, new com.sigmob.sdk.base.views.n(adUnit.resourcePath(), adUnit.getCreativeResourceType(), aVar, 720, 1024));
    }

    public void a(float videoFinish) {
        this.m = videoFinish;
    }

    public void a(final Context context, int contentPlayHead) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void a(Context context, int currentPostion, int duration, final BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void a(c mDialogConfig) {
        this.t = mDialogConfig;
    }

    @Override // com.sigmob.sdk.base.common.i
    public void a(final String dspCreativeId) {
        this.i = dspCreativeId;
    }

    public void a(boolean enableExitOnVideoClose) {
        this.s = enableExitOnVideoClose;
    }

    public void a(boolean isShowForce, int currentPosition, int duration, BaseAdUnit adUnit) {
    }

    public int b(int duration) {
        int i = this.u;
        return (i == 0 || i * 1000 > duration) ? duration : i * 1000;
    }

    @Override // com.sigmob.sdk.base.common.i
    public String b() {
        return this.i;
    }

    public void b(final Context context, int contentPlayHead) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void b(Context context, int currentPostion, int duration, final BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    @Override // com.sigmob.sdk.base.common.i
    public void b(final Context context, final int contentPlayHead, final BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    public void b(boolean mIsAutoRemoveVideoView) {
        this.p = mIsAutoRemoveVideoView;
    }

    public void c(int end_time) {
        this.u = end_time;
    }

    public void c(Context context, int currentPostion, int duration, final BaseAdUnit adUnit) {
        Preconditions.NoThrow.checkNotNull(context, "context cannot be null");
    }

    @Override // com.sigmob.sdk.base.common.i
    public void c(final String customCtaText) {
        if (customCtaText == null) {
            return;
        }
        this.f = customCtaText;
    }

    @Override // com.sigmob.sdk.base.common.i
    public String d() {
        return this.f;
    }

    public void d(int seekPostion) {
        if (seekPostion == 0) {
            return;
        }
        this.n = seekPostion;
    }

    @Override // com.sigmob.sdk.base.common.i
    public void d(final String customSkipText) {
        if (customSkipText == null) {
            return;
        }
        this.g = customSkipText;
    }

    public int e(final int videoDuration) {
        return (int) (videoDuration * (this.o / 100.0f));
    }

    @Override // com.sigmob.sdk.base.common.i
    public String e() {
        return this.g;
    }

    @Override // com.sigmob.sdk.base.common.i
    public void e(final String customCloseIconUrl) {
        if (customCloseIconUrl == null) {
            return;
        }
        this.h = customCloseIconUrl;
    }

    @Override // com.sigmob.sdk.base.common.i
    public String f() {
        return this.h;
    }

    public void f(int mSkipSeconds) {
        this.q = mSkipSeconds;
    }

    public int l() {
        return this.u;
    }

    public boolean m() {
        return this.s;
    }

    public float n() {
        return this.m;
    }

    public int o() {
        return this.n;
    }

    public boolean p() {
        return this.p;
    }

    public c q() {
        return this.t;
    }

    public int r() {
        return 0;
    }

    public boolean s() {
        return this.l;
    }

    public int t() {
        return this.q;
    }
}
