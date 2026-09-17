package com.sigmob.sdk.base.views;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.czhj.sdk.common.utils.ResourceUtil;

/* JADX INFO: loaded from: classes3.dex */
public abstract class x extends LinearLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ImageView f3363a;
    private View b;
    private View c;
    private TextView d;

    public x(Context context) {
        super(context);
        a(context);
    }

    public x(Context context, AttributeSet attrs) {
        super(context, attrs);
        a(context);
    }

    public x(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        a(context);
    }

    private void a(Context context) {
        View viewInflate = inflate(context, ResourceUtil.getLayoutId(context, getResName()), this);
        this.f3363a = (ImageView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_ad_logo"));
        this.b = viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_view"));
        this.c = viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_ll"));
        this.d = (TextView) viewInflate.findViewById(ResourceUtil.getId(context, "sig_ad_privacy_ad_text"));
    }

    public void a(String logoUrl, boolean isShow) {
        if (com.sigmob.sdk.base.utils.s.b(logoUrl)) {
            com.sigmob.sdk.base.common.h.a().load(logoUrl).into(this.f3363a);
        }
        this.b.setVisibility(isShow ? 0 : 8);
    }

    public TextView getPrivacyAdText() {
        return this.d;
    }

    public View getPrivacyLl() {
        return this.c;
    }

    public abstract String getResName();
}
