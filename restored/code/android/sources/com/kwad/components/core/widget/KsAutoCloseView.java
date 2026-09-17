package com.kwad.components.core.widget;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class KsAutoCloseView extends LinearLayout implements View.OnClickListener {
    private static String Fr = "%s秒后自动关闭";
    private TextView awn;
    private ImageView awo;
    private a awp;
    private boolean awq;
    private boolean awr;
    private int countDown;

    public interface a {
        void el();

        void em();
    }

    static /* synthetic */ int e(KsAutoCloseView ksAutoCloseView) {
        int i = ksAutoCloseView.countDown;
        ksAutoCloseView.countDown = i - 1;
        return i;
    }

    public KsAutoCloseView(Context context) {
        super(context);
        this.countDown = 10;
        this.awq = true;
        this.awr = false;
        A(context);
    }

    public KsAutoCloseView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.countDown = 10;
        this.awq = true;
        this.awr = false;
        A(context);
    }

    public KsAutoCloseView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.countDown = 10;
        this.awq = true;
        this.awr = false;
        A(context);
    }

    public void setViewListener(a aVar) {
        this.awp = aVar;
    }

    public KsAutoCloseView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.countDown = 10;
        this.awq = true;
        this.awr = false;
        A(context);
    }

    private void A(Context context) {
        m.inflate(context, R.layout.ksad_auto_close, this);
        this.awn = (TextView) findViewById(R.id.ksad_auto_close_text);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_auto_close_btn);
        this.awo = imageView;
        imageView.setOnClickListener(this);
    }

    public final void ak(int i) {
        if (i <= 0) {
            return;
        }
        this.countDown = i;
        post(new bi() { // from class: com.kwad.components.core.widget.KsAutoCloseView.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (KsAutoCloseView.this.awq) {
                    if (!KsAutoCloseView.this.awr) {
                        if (KsAutoCloseView.this.countDown == 0) {
                            if (KsAutoCloseView.this.awp != null) {
                                KsAutoCloseView.this.awp.el();
                                return;
                            }
                            return;
                        } else {
                            KsAutoCloseView ksAutoCloseView = KsAutoCloseView.this;
                            ksAutoCloseView.G(ksAutoCloseView.countDown);
                            KsAutoCloseView.e(KsAutoCloseView.this);
                            KsAutoCloseView.this.postDelayed(this, 1000L);
                            return;
                        }
                    }
                    KsAutoCloseView.this.postDelayed(this, 1000L);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void G(int i) {
        this.awn.setText(String.format(Fr, Integer.valueOf(i)));
    }

    public void setCountDownPaused(boolean z) {
        this.awr = z;
    }

    public final void bq(boolean z) {
        this.awq = z;
        int i = z ? 0 : 8;
        TextView textView = this.awn;
        if (textView != null) {
            textView.setVisibility(i);
        }
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        if (this.awp != null && view.equals(this.awo)) {
            this.awp.em();
        }
    }
}
