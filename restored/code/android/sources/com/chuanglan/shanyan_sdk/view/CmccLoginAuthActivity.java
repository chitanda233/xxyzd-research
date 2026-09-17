package com.chuanglan.shanyan_sdk.view;

import android.R;
import android.os.Bundle;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.RelativeLayout;
import com.chuanglan.shanyan_sdk.Q;
import com.cmic.gen.sdk.view.GenLoginAuthActivity;

/* JADX INFO: loaded from: classes2.dex */
public class CmccLoginAuthActivity extends GenLoginAuthActivity {
    private void q() {
        RelativeLayout relativeLayout;
        ViewGroup viewGroup = (ViewGroup) ((ViewGroup) getWindow().getDecorView().findViewById(R.id.content)).getChildAt(0);
        if (viewGroup == null || (relativeLayout = (RelativeLayout) viewGroup.findViewById(17476)) == null) {
            return;
        }
        relativeLayout.performClick();
    }

    private void r() {
        try {
            Window window = getWindow();
            WindowManager.LayoutParams attributes = window.getAttributes();
            window.addFlags(24);
            attributes.alpha = 0.0f;
            attributes.width = 1;
            attributes.height = 1;
            attributes.x = 0;
            attributes.y = 0;
            window.setAttributes(attributes);
        } catch (Exception e) {
            Q.d("ExceptionShanYanLogger", "CMCC-SDK initInvisibleWindow Exception", e);
        }
    }

    @Override // com.cmic.gen.sdk.view.GenLoginAuthActivity, android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        r();
    }

    @Override // com.cmic.gen.sdk.view.GenLoginAuthActivity, android.app.Activity
    protected void onDestroy() {
        super.onDestroy();
        Q.a("ProcessShanYanLogger", "CMCC-SDK GenLoginAuthActivity onDestroy");
    }

    @Override // com.cmic.gen.sdk.view.GenLoginAuthActivity, android.app.Activity
    protected void onResume() {
        super.onResume();
        try {
            q();
            Q.a("ProcessShanYanLogger", "CMCC-SDK start onResume");
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "CMCC-SDK loadLibrary Exception", e);
            finish();
        }
    }
}
