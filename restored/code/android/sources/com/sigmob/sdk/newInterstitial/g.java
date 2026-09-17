package com.sigmob.sdk.newInterstitial;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.ResourceUtil;

/* JADX INFO: loaded from: classes4.dex */
public class g extends RelativeLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private View f3603a;

    public g(Context context) {
        super(context);
    }

    public void a(int resId) {
        this.f3603a = inflate(getContext(), resId, this);
    }

    public SigAdInfoView getAdInfView() {
        View view = this.f3603a;
        if (view == null) {
            return null;
        }
        return (SigAdInfoView) view.findViewById(ResourceUtil.getId(getContext(), "sig_app_info"));
    }

    public Button getCTAButton() {
        View view = this.f3603a;
        if (view == null) {
            return null;
        }
        return (Button) view.findViewById(ResourceUtil.getId(getContext(), "sig_cta_button"));
    }

    public NewInterstitialHeaderView getHeaderView() {
        View view = this.f3603a;
        if (view == null) {
            return null;
        }
        return (NewInterstitialHeaderView) view.findViewById(ResourceUtil.getId(getContext(), "sig_ad_header"));
    }

    public ViewGroup getMainAdContainer() {
        View view = this.f3603a;
        if (view == null) {
            return null;
        }
        return (ViewGroup) view.findViewById(ResourceUtil.getId(getContext(), "sig_ad_container"));
    }
}
