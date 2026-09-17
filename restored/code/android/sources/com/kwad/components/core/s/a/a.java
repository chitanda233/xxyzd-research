package com.kwad.components.core.s.a;

import android.content.Intent;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.alipay.sdk.m.c0.d;
import com.kwad.components.core.c.f;
import com.kwad.components.core.webview.tachikoma.k;
import com.kwad.components.offline.api.tk.model.StyleTemplate;
import com.kwad.sdk.R;
import com.kwad.sdk.api.core.KsAdSdkDynamicImpl;
import com.kwad.sdk.api.proxy.app.FeedDownloadActivity;
import com.kwad.sdk.components.n;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.c;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.ConcurrentMap;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
@KsAdSdkDynamicImpl(FeedDownloadActivity.class)
public class a extends com.kwad.components.core.n.b<b> {
    private static final ConcurrentMap<Integer, Map<String, Object>> akW = new ConcurrentHashMap();
    private static final AtomicInteger akX = new AtomicInteger(1);
    private StyleTemplate akP;
    private String akQ;
    private boolean akR;
    private n akS;
    private k akT;
    private com.kwad.components.core.s.b.b akU;
    private int akV;
    private AdResultData mAdResultData;
    private AdBaseFrameLayout mRootContainer;
    private com.kwad.components.core.b.a mTitleBarHelper;

    @Override // com.kwad.components.core.proxy.f
    public String getPageName() {
        return "TKActivityProxy";
    }

    public static void register() {
        c.putComponentProxy(FeedDownloadActivity.class, a.class);
    }

    @Override // com.kwad.components.core.proxy.f
    public int getLayoutId() {
        return R.layout.ksad_tk_page;
    }

    @Override // com.kwad.components.core.proxy.f
    public void initData() {
        this.akR = getIntent().getBooleanExtra("show_navigationBar", true);
        this.akQ = getIntent().getStringExtra(d.w);
        this.akS = (n) bh("native_intent");
    }

    @Override // com.kwad.components.core.proxy.f
    public boolean checkIntentData(Intent intent) {
        this.akV = getIntent().getIntExtra("tk_id", 0);
        String stringExtra = getIntent().getStringExtra("tk_style_template");
        k kVar = (k) bh("tk_view_holder");
        if (TextUtils.isEmpty(stringExtra) && kVar == null) {
            return false;
        }
        if (!TextUtils.isEmpty(stringExtra)) {
            try {
                StyleTemplate styleTemplate = new StyleTemplate();
                styleTemplate.parseJson(new JSONObject(stringExtra));
                this.akP = styleTemplate;
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTrace(th);
                return false;
            }
        }
        if (kVar != null) {
            this.akT = kVar;
        }
        int intExtra = getIntent().getIntExtra("ad_result_cache_idx", 0);
        AdResultData adResultDataD = f.oR().d(intExtra, true);
        this.mAdResultData = adResultDataD;
        return intExtra <= 0 || adResultDataD != null;
    }

    @Override // com.kwad.components.core.proxy.f
    public void initView() {
        this.mRootContainer = (AdBaseFrameLayout) findViewById(R.id.ksad_tk_root_container);
        FrameLayout frameLayout = (FrameLayout) findViewById(R.id.ksad_js_container);
        if (!this.akR && frameLayout != null) {
            FrameLayout.LayoutParams layoutParams = (FrameLayout.LayoutParams) frameLayout.getLayoutParams();
            layoutParams.topMargin = 0;
            frameLayout.setLayoutParams(layoutParams);
        }
        com.kwad.components.core.b.a aVar = new com.kwad.components.core.b.a((ViewGroup) findViewById(R.id.ksad_kwad_web_title_bar));
        this.mTitleBarHelper = aVar;
        aVar.a(new com.kwad.components.core.b.a.InterfaceC0417a() { // from class: com.kwad.components.core.s.a.a.1
            @Override // com.kwad.components.core.b.a.InterfaceC0417a
            public final void x(View view) {
            }

            @Override // com.kwad.components.core.b.a.InterfaceC0417a
            public final void w(View view) {
                a.this.finish();
            }
        });
        this.mTitleBarHelper.a(new com.kwad.components.core.b.b(this.akQ));
        this.mTitleBarHelper.ak(false);
    }

    @Override // com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onBackPressed() {
        com.kwad.components.core.s.b.b bVar = this.akU;
        if (bVar == null || !bVar.onBackPressed()) {
            super.onBackPressed();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.core.n.b
    /* JADX INFO: renamed from: wH, reason: merged with bridge method [inline-methods] */
    public b onCreateCallerContext() {
        b bVar = new b(this);
        bVar.a(this.mAdResultData);
        bVar.akP = this.akP;
        bVar.mRootContainer = this.mRootContainer;
        bVar.akS = this.akS;
        bVar.akT = this.akT;
        return bVar;
    }

    @Override // com.kwad.components.core.n.b
    public Presenter onCreatePresenter() {
        if (this.akP != null) {
            return new com.kwad.components.core.s.b.a();
        }
        if (this.akU == null) {
            this.akU = new com.kwad.components.core.s.b.b();
        }
        return this.akU;
    }

    @Override // com.kwad.components.core.n.b, com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onResume() {
        super.onResume();
    }

    @Override // com.kwad.components.core.n.b, com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onPause() {
        super.onPause();
    }

    @Override // com.kwad.components.core.n.b, com.kwad.components.core.proxy.f, com.kwad.sdk.api.proxy.IActivityProxy
    public void onDestroy() {
        try {
            super.onDestroy();
            bN(this.akV);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private Object bh(String str) {
        return r(this.akV, str);
    }

    public static int wI() {
        return akX.incrementAndGet();
    }

    private static Object r(int i, String str) {
        Map<String, Object> map = akW.get(Integer.valueOf(i));
        if (map != null) {
            return map.get(str);
        }
        return null;
    }

    public static void a(int i, String str, Object obj) {
        ConcurrentMap<Integer, Map<String, Object>> concurrentMap = akW;
        Map<String, Object> map = concurrentMap.get(Integer.valueOf(i));
        if (map == null) {
            map = new HashMap<>();
            concurrentMap.put(Integer.valueOf(i), map);
        }
        map.put(str, obj);
    }

    private static void bN(int i) {
        Map<String, Object> map = akW.get(Integer.valueOf(i));
        if (map != null) {
            map.clear();
        }
    }
}
