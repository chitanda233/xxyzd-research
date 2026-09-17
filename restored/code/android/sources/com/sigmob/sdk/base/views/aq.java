package com.sigmob.sdk.base.views;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.TextView;

/* JADX INFO: loaded from: classes3.dex */
public class aq extends LinearLayout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private TextView f3302a;
    private TextView b;

    public aq(Context context) {
        super(context);
        a();
    }

    public aq(Context context, AttributeSet attrs) {
        super(context, attrs);
        a();
    }

    public aq(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
        a();
    }

    private void a() {
        TextView textView = new TextView(getContext());
        this.f3302a = textView;
        textView.setId(View.generateViewId());
        this.b = new TextView(getContext());
        setOrientation(1);
        LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(-1, -2);
        this.f3302a.setTextColor(-1);
        this.f3302a.setSingleLine();
        this.f3302a.setGravity(17);
        this.f3302a.setTextSize(2, 20.0f);
        this.b.setSingleLine();
        this.b.setTextColor(-1);
        this.b.setGravity(17);
        this.b.setTextSize(2, 14.0f);
        addView(this.f3302a, layoutParams);
        addView(this.b, new LinearLayout.LayoutParams(-1, -2));
    }

    public void setDescription(String description) {
        this.b.setText(description);
    }

    public void setTitle(String title) {
        this.f3302a.setText(title);
    }
}
