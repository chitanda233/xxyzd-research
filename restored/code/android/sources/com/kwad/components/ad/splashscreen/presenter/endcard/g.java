package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.content.Context;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.am;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private float JY;
    private Context mContext;

    public g(Context context, float f) {
        this.mContext = context;
        this.JY = f;
    }

    public final am nm() {
        return new am(g(this.mContext, R.dimen.ksad_splash_endcard_title_iconw_land), g(this.mContext, R.dimen.ksad_splash_endcard_title_iconh_land));
    }

    public final am nn() {
        return new am(g(this.mContext, R.dimen.ksad_splash_endcard_gift_iconw_land), g(this.mContext, R.dimen.ksad_splash_endcard_gift_iconh_land));
    }

    public final am no() {
        int iG = g(this.mContext, R.dimen.ksad_splash_endcard_app_iconw_land);
        int iG2 = g(this.mContext, R.dimen.ksad_splash_endcard_app_iconh_land);
        int iG3 = g(this.mContext, R.dimen.ksad_splash_endcard_app_margin_top_land);
        am amVar = new am(iG, iG2);
        amVar.fO(iG3);
        return amVar;
    }

    public final int np() {
        return com.kwad.sdk.c.a.a.px2dip(this.mContext, (int) (g(this.mContext, R.dimen.ksad_splash_endcard_app_iconw_land) * 0.24f));
    }

    public final am nq() {
        return new am(g(this.mContext, R.dimen.ksad_splash_endcard_actionbar_iconw_land), g(this.mContext, R.dimen.ksad_splash_endcard_actionbar_iconh_land));
    }

    public final am nr() {
        int iG = g(this.mContext, R.dimen.ksad_splash_endcard_appname_h_land);
        int iG2 = g(this.mContext, R.dimen.ksad_splash_endcard_appname_margin_top_land);
        am amVar = new am(0, iG);
        amVar.fO(iG2);
        return amVar;
    }

    public final am ns() {
        return new am(0, g(this.mContext, R.dimen.ksad_splash_endcard_appver_h_land));
    }

    public final am nt() {
        int iG = g(this.mContext, R.dimen.ksad_splash_endcard_appdesc_h_land);
        int iG2 = g(this.mContext, R.dimen.ksad_splash_endcard_appdesc_margin_top_land);
        am amVar = new am(0, iG);
        amVar.fO(iG2);
        return amVar;
    }

    public final am nu() {
        int iG = g(this.mContext, R.dimen.ksad_splash_endcard_close_root_h_land);
        int iG2 = g(this.mContext, R.dimen.ksad_splash_endcard_close_root_margin_top_land);
        am amVar = new am(0, iG);
        amVar.fO(iG2);
        return amVar;
    }

    public final int nv() {
        return g(this.mContext, R.dimen.ksad_splash_endcard_appname_text_sp_land);
    }

    public final int nw() {
        return g(this.mContext, R.dimen.ksad_splash_endcard_appver_text_sp_land);
    }

    public final int nx() {
        return g(this.mContext, R.dimen.ksad_splash_endcard_appdesc_text_sp_land);
    }

    public final int ny() {
        return g(this.mContext, R.dimen.ksad_splash_endcard_ab_title_text_sp_land);
    }

    public final int nz() {
        return g(this.mContext, R.dimen.ksad_splash_endcard_ab_subtitle_text_sp_land);
    }

    private int g(Context context, int i) {
        return (int) (com.kwad.sdk.c.a.a.h(context, i) * this.JY);
    }
}
